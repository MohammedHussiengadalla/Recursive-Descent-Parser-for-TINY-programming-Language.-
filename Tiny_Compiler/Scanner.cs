using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Token_Class
{
    //reserved words
    T_Integer, T_Float, T_String, T_Read, T_Write, T_Repeat, T_Until, T_If,
    T_Elseif, T_Else, T_Then, T_Return, T_Endl,
    //operators
    T_PlusOp, T_MinusOp, T_MultiplyOp, T_DivideOp, T_EqualOp, T_LParanthesis,
    T_LessThanOp, T_GreaterThanOp, T_NotEqualOp, T_AndOp, T_OrOp, T_RParanthesis,
    T_LCurlyBracket, T_RCurlyBracket, T_Semicolon, T_Dot, T_Comma,
    //other tokens
    T_Idenifier, T_Number
}
namespace Tiny_Compiler
{


    public class Token
    {
        public string lex;
        public Token_Class token_type;
    }

    public class Scanner
    {
        public List<Token> Tokens = new List<Token>();
        Dictionary<string, Token_Class> ReservedWords = new Dictionary<string, Token_Class>();
        Dictionary<string, Token_Class> Operators = new Dictionary<string, Token_Class>();

        public Scanner()
        {
            //Reserved Words
            ReservedWords.Add("int", Token_Class.T_Integer);
            ReservedWords.Add("float", Token_Class.T_Float);
            ReservedWords.Add("string", Token_Class.T_String);
            ReservedWords.Add("read", Token_Class.T_Read);
            ReservedWords.Add("write", Token_Class.T_Write);
            ReservedWords.Add("repeat", Token_Class.T_Repeat);
            ReservedWords.Add("until", Token_Class.T_Until);
            ReservedWords.Add("if", Token_Class.T_If);
            ReservedWords.Add("elseif", Token_Class.T_Elseif);
            ReservedWords.Add("else", Token_Class.T_Else);
            ReservedWords.Add("then", Token_Class.T_Then);
            ReservedWords.Add("return", Token_Class.T_Return);
            ReservedWords.Add("endl", Token_Class.T_Endl);


            //Operators
            Operators.Add(".", Token_Class.T_Dot);
            Operators.Add(";", Token_Class.T_Semicolon);
            Operators.Add(",", Token_Class.T_Comma);
            Operators.Add("(", Token_Class.T_LParanthesis);
            Operators.Add(")", Token_Class.T_RParanthesis);
            Operators.Add("{", Token_Class.T_LCurlyBracket);
            Operators.Add("}", Token_Class.T_RCurlyBracket);
            Operators.Add(":=", Token_Class.T_EqualOp);
            Operators.Add("<", Token_Class.T_LessThanOp);
            Operators.Add(">", Token_Class.T_GreaterThanOp);
            Operators.Add("<>", Token_Class.T_NotEqualOp);
            Operators.Add("+", Token_Class.T_PlusOp);
            Operators.Add("-", Token_Class.T_MinusOp);
            Operators.Add("*", Token_Class.T_MultiplyOp);
            Operators.Add("/", Token_Class.T_DivideOp);
            Operators.Add("&&", Token_Class.T_AndOp);
            Operators.Add("||", Token_Class.T_OrOp);


        }

        public void StartScanning(string SourceCode)
        {
            string CurrentLexeme = "";
            UInt32 state = 1;
            Tokens.Clear();
            Errors.Error_List.Clear();
            for (int i = 0; i < SourceCode.Length; i++)
            {

                char CurrentChar = SourceCode[i];

                if (state == 1)
                {
                    if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                        continue;

                    else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 3;
                    }
                    else if (CurrentChar >= '0' && CurrentChar <= '9')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 4;
                    }
                    //if current char is special char
                    else
                    {
                        CurrentLexeme += CurrentChar;
                        state = 2;
                    }
                }

                else if (state == 2)
                {
                    
                    /* you have at least one special char in CurrentLexeme */
                    if (CurrentLexeme == "/" && CurrentChar == '*')
                    {
                            CurrentLexeme += CurrentChar;
                            state = 7;
                        
                    }
                    else if (CurrentLexeme == "\"")
                    {
                        CurrentLexeme += CurrentChar;
                        state = 10;
                    }
                    else if(CurrentLexeme=="(" || CurrentLexeme==")" || CurrentChar == '}' || CurrentChar == '{')
                    {
                        AddToken(CurrentLexeme, Operators[CurrentLexeme]);
                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;
                        else if (CurrentChar >= '0' && CurrentChar <= '9')
                        {
                            CurrentLexeme = CurrentChar.ToString();
                            state = 4;
                        }
                            
                        else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                        {
                            CurrentLexeme = CurrentChar.ToString();
                            state = 3;
                        }
                            
                        else
                            CurrentLexeme = CurrentChar.ToString();
                    }
                    //Curenet lexeme ends here and new lexeme starts
                    else if ((CurrentChar >= '0' && CurrentChar <= '9') || (CurrentChar >= 'A' && CurrentChar <= 'z') ||
                              CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t'||
                              CurrentChar == '(' || CurrentChar == ')'||CurrentChar == '}' || CurrentChar == '{')
                    {
                        //adding Token if operator exist 
                        if (Operators.ContainsKey(CurrentLexeme))
                            AddToken(CurrentLexeme, Operators[CurrentLexeme]);
                        //Rais Error if operator Not exist
                        else
                            RaiseError(string.Format(Errors.ErrorMsg["OpEr"], CurrentLexeme));


                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;
                        else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                        {
                            CurrentLexeme += CurrentChar;
                            state = 3;
                        }
                      
                        else if (CurrentChar == '('|| CurrentChar == ')' || CurrentChar == '}' || CurrentChar == '{')
                        {
                            CurrentLexeme += CurrentChar;
                            //stay in state 2
                        }
                        //if current char is number
                        else
                        {
                            CurrentLexeme += CurrentChar;
                            state = 4;
                        }

                    }

                    // if currentChar is spacial character too
                    else
                    {
                        if (CurrentChar == '/')
                        {
                            if (SourceCode[i + 1] == '*')
                            {
                                //adding Token if operator exist 
                                if (Operators.ContainsKey(CurrentLexeme))
                                    AddToken(CurrentLexeme, Operators[CurrentLexeme]);
                                //Rais Error if operator Not exist
                                else
                                    RaiseError(string.Format(Errors.ErrorMsg["OpEr"], CurrentLexeme));

                                CurrentLexeme = string.Empty;
                                CurrentLexeme += CurrentChar;
                                state = 7;
                            }
                            else
                                CurrentLexeme += CurrentChar;

                        }
                        else if (CurrentChar == '\"')
                        {
                            //adding Token if operator exist 
                            if (Operators.ContainsKey(CurrentLexeme))
                                AddToken(CurrentLexeme, Operators[CurrentLexeme]);
                            //Rais Error if operator Not exist
                            else
                                RaiseError(string.Format(Errors.ErrorMsg["OpEr"], CurrentLexeme));

                            CurrentLexeme = string.Empty;
                            CurrentLexeme += CurrentChar;
                            state = 10;
                        }

                        else
                            CurrentLexeme += CurrentChar;
                        //leave ( state = 2 ) as it is
                    }
                }

                else if (state == 3)
                {
                    //sum of char to 
                    /* you have at least one char in CurrentLexeme */
                    if ((CurrentChar >= 'A' && CurrentChar <= 'z') || (CurrentChar >= '0' && CurrentChar <= '9'))
                    {
                        CurrentLexeme += CurrentChar;
                        //Leave ( State = 3 ) as it is 
                    }
                    else
                    {
                        if (ReservedWords.ContainsKey(CurrentLexeme))
                            AddToken(CurrentLexeme, ReservedWords[CurrentLexeme]);
                        else
                            AddToken(CurrentLexeme, Token_Class.T_Idenifier);

                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;
                        //if CurrentChar is Spacial Char
                        else
                        {
                            CurrentLexeme += CurrentChar;
                            state = 2;
                        }
                    }
                }
                 
                else if (state == 4)
                {
                    /* you have at least number*/
                    if (CurrentChar >= '0' && CurrentChar <= '9')
                    {
                        CurrentLexeme += CurrentChar;
                        //stay in stksnvate 4
                    }
                    else if (CurrentChar == '.')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 5;
                    }
                    else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 6;
                    }
                    //current char is spacial char or spacing 
                    else
                    {
                        AddToken(CurrentLexeme, Token_Class.T_Number);
                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;
                        else
                        {
                            CurrentLexeme += CurrentChar;
                            state = 2;
                        }
                    }
                }

                else if (state == 5)
                {
                    /*you have (number.)*/
                    if (CurrentChar >= '0' && CurrentChar <= '9')
                    {
                        CurrentLexeme += CurrentChar;
                        //Stay in state 5
                    }
                    else if ((CurrentChar >= 'A' && CurrentChar <= 'z') || CurrentChar == '.')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 6;
                    }
                    //if CurrentChar special char or spacing
                    else
                    {
                        AddToken(CurrentLexeme, Token_Class.T_Number);
                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;
                        else
                        {
                            CurrentLexeme += CurrentChar;
                            state = 2;
                        }
                    }
                }

                else if (state == 6)
                {
                    if ((CurrentChar >= '0' && CurrentChar <= '9') || (CurrentChar >= 'A' && CurrentChar <= 'z') || CurrentChar == '.')
                        CurrentLexeme += CurrentChar;
                    else
                    {
                        RaiseError(string.Format(Errors.ErrorMsg["IDEr"], CurrentLexeme));
                        CurrentLexeme = string.Empty;
                        if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                            state = 1;

                        //if current char is spacial char 
                        else
                        {
                            CurrentLexeme += CurrentChar;
                            state = 2;
                        }
                    }
                }

                else if (state == 7)
                {
                    CurrentLexeme += CurrentChar;
                    if (CurrentChar == '*')
                        state = 8;
                }
                else if (state == 8)
                {
                    CurrentLexeme += CurrentChar;
                    if (CurrentChar == '/')
                        state = 9;
                    else if (CurrentChar == '*') {/*leave state = 8 */ }

                    else
                        state = 7;
                }

                else if (state == 9)
                {/* you have a completed comment */
                    CurrentLexeme = string.Empty;
                    if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                        state = 1;

                    else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 3;
                    }

                    else if (CurrentChar >= '0' && CurrentChar <= '9')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 4;
                    }

                    else
                    {
                        CurrentLexeme += CurrentChar;
                        state = 2;
                    }
                }

                else if (state == 10)
                {/*you have at least a " as starting of a string*/
                    if (CurrentChar == '\"')
                        state = 11;
                    else if (CurrentChar == '\r'|| CurrentChar=='\n')
                    {
                        RaiseError(string.Format(Errors.ErrorMsg["StrEr"], CurrentLexeme));
                        CurrentLexeme = string.Empty;
                        state = 1;
                    }
                    else
                        CurrentLexeme += CurrentChar;
                    //and stay in state 10
                }
                else if (state == 11)
                {/*you have properly Completed string*/
                    //Add the string in the literal table
                    LiteralTable.Literals.Add(CurrentLexeme);

                    CurrentLexeme = string.Empty;
                    if (CurrentChar == ' ' || CurrentChar == '\r' || CurrentChar == '\n' || CurrentChar == '\t')
                        state = 1;

                    else if (CurrentChar >= 'A' && CurrentChar <= 'z')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 3;
                    }

                    else if (CurrentChar >= '0' && CurrentChar <= '9')
                    {
                        CurrentLexeme += CurrentChar;
                        state = 4;
                    }

                    else
                    {
                        CurrentLexeme += CurrentChar;
                        state = 2;
                    }

                }
            }

            Tiny_Compiler.TokenStream = Tokens;
        }

        void AddToken(string Lex, Token_Class Tok)
        {
            Token NewToken = new Token();
            NewToken.lex = Lex;
            NewToken.token_type = Tok;
            Tokens.Add(NewToken);
        }
        void RaiseError(string ErrMsg)
        {
            Errors.Error_List.Add(ErrMsg);
        }

        /*
        void FindTokenClass(string Lex)
        {
            Token_Class TC;
            Token Tok = new Token();
            Tok.lex = Lex;
            //Is it a reserved word?
            if (this.ReservedWords.ContainsKey(Tok.lex))
            {
                TC = ReservedWords[Tok.lex];
                Tok.token_type = TC;
                //adding Token
                Tokens.Add(Tok);
            }

            //Is it an identifier?
            else if (this.isIdentifier(Tok.lex)) {
                TC = Token_Class.T_Idenifier;
                Tok.token_type = TC;
                //adding Token
                Tokens.Add(Tok);
            }

            //Is it a Number?
            else if (this.isNumber(Tok.lex)) {
                TC = Token_Class.T_Number;
                Tok.token_type = TC;
                //adding Token
                Tokens.Add(Tok);
            }
            //Is it an operator?
            else if (this.Operators.ContainsKey(Tok.lex)) { 
                TC=Operators[Tok.lex];
                Tok.token_type = TC;
                //adding Token
                Tokens.Add(Tok);
            }

          
        }

        //detect error in lexeme
        

        bool isIdentifier(string lex)
        {
            bool isValid=true;
            if (lex[0] >= 'A' && lex[0] <= 'z')
            {

                int i = 1;
                while (i < lex.Length && ((lex[i] >= 'A' && lex[i] <= 'z') || (lex[i] >= 0 && lex[i] <= 9)))
                    i++;

                if (i < lex.Length)
                {
                    isValid = false;
                    //add error (unallowed spalcial caracter at identifier +lex)

                }
            }

            else {
                isValid = false;
                //add error (un allowed for identifier to start with digit)
            }
            return isValid;
        }

        bool isNumber(string lex)
        {
            bool isValid = true;
            bool isDecimalPointExist = false;
           
            for (int i = 0; i < lex.Length; i++) {
               
                if (lex[i] >= 0 && lex[i] <= 9)
                    continue;
               
                else if (lex[i]=='.'){
                    
                    if (isDecimalPointExist)
                    {
                        isValid = false;
                        return isValid;
                    }
                    else{
                        isDecimalPointExist = true;
                        continue;
                    }
                }

                else{
                    isValid=false;
                    return isValid;
                }

            }
            return isValid;
        }
        */


    }
}
