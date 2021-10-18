using System;

namespace ProjetoFinal
{
    public class Identifier
    {
        public string inputCharacter;

        public Identifier(string inputCharacter)
        {
            this.inputCharacter = inputCharacter;
        }

        // Executa a validação completa na string
        public bool ValidateIdentifier()
        {
            int i = 0;
            char currentCharacter;
            bool validId = false;

            if (inputCharacter.Length > 0)
            {
                currentCharacter = inputCharacter[0];
                validId = ValidateFirst(currentCharacter);
                if (inputCharacter.Length > 1)
                {
                    i = 1;
                    while (i < inputCharacter.Length)
                    {
                        currentCharacter = inputCharacter[i];
                        if (!ValidateBody(currentCharacter))
                            validId = false;
                        i++;
                    }
                }
            }

            if((validId) && (inputCharacter.Length >= 1) && (inputCharacter.Length < 6))
                return true;
            else
                return false;
        }

        // Função auxiliar que valida o primeiro caracter da string
        public bool ValidateFirst(char firstCharacter)
        {
            if (((firstCharacter >= 'A') && (firstCharacter <= 'Z')) || ((firstCharacter >= 'a') && (firstCharacter <= 'z')))
                return true;
            else
                return false;
        }

        // Função auxiliar que valida um caracter (não primeiro) da string 
        public bool ValidateBody(char stringCharacter)
        {
            if (((stringCharacter >= 'A') && (stringCharacter <= 'Z'))
            || ((stringCharacter >= 'a') && (stringCharacter <= 'z'))
            || ((stringCharacter >= '0') && (stringCharacter <= '9')))
                return true;
            else
                return false;
        }

    }
}