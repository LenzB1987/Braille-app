using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille_Assist_App
{
    internal class Braille_Table
    {
        private static bool UpperCaseCharacterFlag = false;
        private static bool UpperCaseWordFlag = false;
        private static bool NumericModeFlag = false;

        static public void ResetFlags()
        {
            UpperCaseCharacterFlag = false;
            NumericModeFlag = false;
            UpperCaseWordFlag = false;
        }


        static public string ToBraille(char value)
        {
            string braille = "";
            string bhex = "";
            string bdots = "";

            //Punctuation
            //We use the following on their own
            /*
             * , . : ; ! ? ' -
             *
             */

            // These are capital letters convert to lowercase and add identifier
            if (((value >= 'A') && (value <= 'Z')) || (value == 'Ŋ') || (value == 'Ə'))
            {
                value = Char.ToLower(value);

                if (!UpperCaseCharacterFlag) //flag set only once at start of number
                {
                    braille = "\u2820";
                    UpperCaseCharacterFlag = true;
                    UpperCaseWordFlag = true;
                }
                else // must be an uppercase word?
                {
                    //ToDo identify the whole word when in Uppercase
                    UpperCaseWordFlag = false;
                }
            }
            else
            {
                UpperCaseCharacterFlag = false;
            }

            // These are numbers add identifier
            if ((value >= '0') && (value <= '9'))
            {
                if (!NumericModeFlag)//flag set only once at start of number
                {
                    braille = "\u283C";
                    NumericModeFlag = true;
                }
            }
            else
            {
                NumericModeFlag = false;
            }

            switch (value)
            {
                ///////////////////////////////////////////////
                // Prefixed Section - These have Prefix + Root
                ///////////////////////////////////////////////

                // There are 6 prefix characters
                /*
                 * \u283C = ⠼ = 3456
                 * \u2808 = ⠈ = 4
                 * \u2818 = ⠘ = 45
                 * \u2828 = ⠨ = 46
                 * \u2838 = ⠸ = 456
                 * \u2810 = ⠐ = 5
                 *
                 * There are 2 special prefix which may be used in combination with another
                   special prefix to form a braille sign. Such braille signs are used only
                   as indicators.
                 * \u2830 = ⠰ = 56
                 * \u2820 = ⠠ = 6
                 */

                // “ ” ‘ ’ « » " ( ) [ ] < > { } / \  — _ 
                case '“': braille += "\u2818\u2826"; bhex = "⠘⠦"; bdots = "45 + 236"; break;
                case '”': braille += "\u2818\u2834"; bhex = "⠘⠴"; bdots = "45 + 356"; break;
                case '‘': braille += "\u2820\u2826"; bhex = "⠘⠦"; bdots = "6 + 236"; break;
                case '’': braille += "\u2820\u2834"; bhex = "⠘⠴"; bdots = "6 + 356"; break;
                case '«': braille += "\u2838\u2826"; bhex = "⠘⠦"; bdots = "456 + 236"; break;
                case '»': braille += "\u2838\u2834"; bhex = "⠘⠴"; bdots = "456 + 356"; break;

                case '"': braille += "\u2820\u2836"; bhex = "⠠⠶"; bdots = "6 + 2356"; break;

                case '(': braille += "\u2810\u2823"; bhex = "⠐⠣"; bdots = "5 + 126"; break;
                case ')': braille += "\u2828\u281C"; bhex = "⠐⠜"; bdots = "5 + 345"; break;
                case '[': braille += "\u2828\u2823"; bhex = "⠨⠣"; bdots = "46 + 126"; break;
                case ']': braille += "\u2810\u281C"; bhex = "⠨⠜"; bdots = "46 + 345"; break;
                case '<': braille += "\u2804\u2823"; bhex = "⠄⠣"; bdots = "3 + 126"; break;
                case '>': braille += "\u2804\u281C"; bhex = "⠄⠜"; bdots = "3 + 345"; break;
                case '{': braille += "\u2838\u2823"; bhex = "⠸⠣"; bdots = "456 + 126"; break;
                case '}': braille += "\u2838\u281C"; bhex = "⠸⠜"; bdots = "456 + 345"; break;

                case '/': braille += "\u2838\u280C"; bhex = "⠸⠌"; bdots = "456 + 34"; break;
                case '\\': braille += "\u2838\u2821"; bhex = "⠸⠡"; bdots = "456 + 16"; break;

                case '—': braille += "\u2820\u2824"; bhex = "⠠⠤"; bdots = "6 + 36"; break;
                //case '——': braille += "\u2824"; bhex = "??"; bdots = "36"; break;//Long Dash is two dash \U2014
                case '_': braille += "\u2828\u2824"; bhex = "⠨⠤"; bdots = "46 + 36"; break;

                ////////////////////////////////////////////////
                //Root Section - These are 56 single glyphs
                ////////////////////////////////////////////////

                case 'a': braille += "\u2801"; bhex = "⠁"; bdots = "1"; break;
                case '1': braille += "\u2801"; bhex = "⠁"; bdots = "1"; break;

                case 'b': braille += "\u2803"; bhex = "⠃"; bdots = "12"; break;
                case '2': braille += "\u2803"; bhex = "⠃"; bdots = "12"; break;

                case 'c': braille += "\u2809"; bhex = "⠉"; bdots = "14"; break;
                case '3': braille += "\u2809"; bhex = "⠉"; bdots = "14"; break;

                case 'd': braille += "\u2819"; bhex = "⠙"; bdots = "145"; break;
                case '4': braille += "\u2819"; bhex = "⠙"; bdots = "145"; break;

                case 'e': braille += "\u2811"; bhex = "⠑"; bdots = "15"; break;
                case '5': braille += "\u2811"; bhex = "⠑"; bdots = "15"; break;

                case 'f': braille += "\u280B"; bhex = "⠋"; bdots = "124"; break;
                case '6': braille += "\u280B"; bhex = "⠋"; bdots = "124"; break;

                case 'g': braille += "\u281B"; bhex = "⠛"; bdots = "1245"; break;
                case '7': braille += "\u281B"; bhex = "⠛"; bdots = "1245"; break;

                case 'h': braille += "\u2813"; bhex = "⠓"; bdots = "125"; break;
                case '8': braille += "\u2813"; bhex = "⠓"; bdots = "125"; break;

                case 'i': braille += "\u280A"; bhex = "⠊"; bdots = "24"; break;
                case '9': braille += "\u280A"; bhex = "⠊"; bdots = "24"; break;

                case 'j': braille += "\u281A"; bhex = "⠚"; bdots = "245"; break;
                case '0': braille += "\u281A"; bhex = "⠚"; bdots = "245"; break;

                case 'k': braille += "\u2805"; bhex = "⠅"; bdots = "13"; break;
                case 'l': braille += "\u2807"; bhex = "⠇"; bdots = "123"; break;
                case 'm': braille += "\u280D"; bhex = "⠍"; bdots = "134"; break;
                case 'n': braille += "\u281D"; bhex = "⠝"; bdots = "1345"; break;
                case 'o': braille += "\u2815"; bhex = "⠕"; bdots = "135"; break;
                case 'p': braille += "\u280F"; bhex = "⠏"; bdots = "1234"; break;
                case 'q': braille += "\u281F"; bhex = "⠟"; bdots = "12345"; break;
                case 'r': braille += "\u2817"; bhex = "⠗"; bdots = "1235"; break;
                case 's': braille += "\u280E"; bhex = "⠎"; bdots = "234"; break;
                case 't': braille += "\u281E"; bhex = "⠞"; bdots = "2345"; break;
                case 'u': braille += "\u2825"; bhex = "⠥"; bdots = "136"; break;
                case 'v': braille += "\u2827"; bhex = "⠧"; bdots = "1236"; break;
                case 'w': braille += "\u283A"; bhex = "⠺"; bdots = "2456"; break;
                case 'x': braille += "\u282D"; bhex = "⠭"; bdots = "1346"; break;
                case 'y': braille += "\u283D"; bhex = "⠽"; bdots = "13456"; break;
                case 'z': braille += "\u2835"; bhex = "⠵"; bdots = "1356"; break;

                case 'ŋ': braille += "\u2818\u281D"; bhex = "⠘⠝"; bdots = "45 + 1345"; break; //eng from International Phonetic Alphabet
                case 'ə': braille += "\u2838\u2822"; bhex = "⠸⠢"; bdots = "456 + 26"; break; //schwa from International Phonetic Alphabet



                ///////////////////////////////////////////////////////////////////
                // Greek for Scientific Notation
                ///////////////////////////////////////////////////////////////////

                case 'α': braille += "\u2828\u2801"; bhex = "⠨⠁"; bdots = "46 + 1"; break; // alpha
                case 'β': braille += "\u2828\u2803"; bhex = "⠨⠃"; bdots = "46 + 12"; break; // beta
                case 'γ': braille += "\u2828\u281B"; bhex = "⠨⠛"; bdots = "46 + 1245"; break; // gamma
                case 'δ': braille += "\u2828\u2819"; bhex = "⠨⠙"; bdots = "46 + 145"; break; // delta
                case 'ε': braille += "\u2828\u2811"; bhex = "⠨⠑"; bdots = "46 + 15"; break; // epsilon
                case 'ζ': braille += "\u2828\u2835"; bhex = "⠨⠵"; bdots = "46 + 1356"; break; // zeta
                case 'η': braille += "\u2828\u2831"; bhex = "⠨⠱"; bdots = "46 + 156"; break; // eta
                case 'θ': braille += "\u2828\u2839"; bhex = "⠨⠹"; bdots = "46 + 1456"; break; // theta
                case 'ι': braille += "\u2828\u280A"; bhex = "⠨⠊"; bdots = "46 + 24"; break; // iota
                case 'κ': braille += "\u2828\u2805"; bhex = "⠨⠅"; bdots = "46 + 13"; break; // kappa
                case 'λ': braille += "\u2828\u2807"; bhex = "⠨⠇"; bdots = "46 + 123"; break; // lambda
                case 'μ': braille += "\u2828\u280D"; bhex = "⠨⠍"; bdots = "46 + 134"; break; // mu
                case 'ν': braille += "\u2828\u281D"; bhex = "⠨⠝"; bdots = "46 + 1345"; break; // nu
                case 'ξ': braille += "\u2828\u282D"; bhex = "⠨⠭"; bdots = "46 + 1346"; break; // xi
                case 'ο': braille += "\u2828\u2815"; bhex = "⠨⠕"; bdots = "46 + 135"; break; // omicron
                case 'π': braille += "\u2828\u280F"; bhex = "⠨⠏"; bdots = "46 + 1234"; break; // pi
                case 'ρ': braille += "\u2828\u2817"; bhex = "⠨⠗"; bdots = "46 + 1235"; break; // rho
                case 'ς': braille += "\u2828\u280E"; bhex = "⠨⠎"; bdots = "46 + 234"; break; // sigma
                case 'σ': braille += "\u2828\u280E"; bhex = "⠨⠎"; bdots = "46 + 234"; break; // sigma
                case 'τ': braille += "\u2828\u281E"; bhex = "⠨⠞"; bdots = "46 + 2345"; break; // tau
                case 'υ': braille += "\u2828\u2825"; bhex = "⠨⠥"; bdots = "46 + 136"; break; // upsilon
                case 'φ': braille += "\u2828\u280B"; bhex = "⠨⠋"; bdots = "46 + 124"; break; // phi
                case 'χ': braille += "\u2828\u282F"; bhex = "⠨⠯"; bdots = "46 + 12346"; break; // chi
                case 'ψ': braille += "\u2828\u283D"; bhex = "⠨⠽"; bdots = "46 + 13456"; break; // psi
                case 'ω': braille += "\u2828\u283A"; bhex = "⠨⠺"; bdots = "46 + 2456"; break; // omega

                case 'Α': braille += "\u2820\u2828\u2801"; bhex = "⠠⠨⠁"; bdots = "6 + 46 + 1"; break; // Upper alpha
                case 'Β': braille += "\u2820\u2828\u2803"; bhex = "⠠⠨⠃"; bdots = "6 + 46 + 12"; break; // Upper beta
                case 'Γ': braille += "\u2820\u2828\u281B"; bhex = "⠠⠨⠛"; bdots = "6 + 46 + 1245"; break; // Upper gamma
                case 'Δ': braille += "\u2820\u2828\u2819"; bhex = "⠠⠨⠙"; bdots = "6 + 46 + 145"; break; // Upper delta
                case 'Ε': braille += "\u2820\u2828\u2811"; bhex = "⠠⠨⠑"; bdots = "6 + 46 + 15"; break; // Upper epsilon
                case 'Ζ': braille += "\u2820\u2828\u2835"; bhex = "⠠⠨⠵"; bdots = "6 + 46 + 1356"; break; // Upper zeta
                case 'Η': braille += "\u2820\u2828\u2831"; bhex = "⠠⠨⠱"; bdots = "6 + 46 + 156"; break; // Upper eta
                case 'Θ': braille += "\u2820\u2828\u2839"; bhex = "⠠⠨⠹"; bdots = "6 + 46 + 1456"; break; // Upper theta
                case 'Ι': braille += "\u2820\u2828\u280A"; bhex = "⠠⠨⠊"; bdots = "6 + 46 + 24"; break; // Upper iota
                case 'Κ': braille += "\u2820\u2828\u2805"; bhex = "⠠⠨⠅"; bdots = "6 + 46 + 13"; break; // Upper kappa
                case 'Λ': braille += "\u2820\u2828\u2807"; bhex = "⠠⠨⠇"; bdots = "6 + 46 + 123"; break; // Upper lambda
                case 'Μ': braille += "\u2820\u2828\u280D"; bhex = "⠠⠨⠍"; bdots = "6 + 46 + 134"; break; // Upper mu
                case 'Ν': braille += "\u2820\u2828\u281D"; bhex = "⠠⠨⠝"; bdots = "6 + 46 + 1345"; break; // Upper nu
                case 'Ξ': braille += "\u2820\u2828\u282D"; bhex = "⠠⠨⠭"; bdots = "6 + 46 + 1346"; break; // Upper xi
                case 'Ο': braille += "\u2820\u2828\u2815"; bhex = "⠠⠨⠕"; bdots = "6 + 46 + 135"; break; // Upper omicron
                case 'Π': braille += "\u2820\u2828\u280F"; bhex = "⠠⠨⠏"; bdots = "6 + 46 + 1234"; break; // Upper pi
                case 'Ρ': braille += "\u2820\u2828\u2817"; bhex = "⠠⠨⠗"; bdots = "6 + 46 + 1235"; break; // Upper rho
                case 'Σ': braille += "\u2820\u2828\u280E"; bhex = "⠠⠨⠎"; bdots = "6 + 46 + 234"; break; // Upper sigma
                case 'Τ': braille += "\u2820\u2828\u281E"; bhex = "⠠⠨⠞"; bdots = "6 + 46 + 2345"; break; // Upper tau
                case 'Υ': braille += "\u2820\u2828\u2825"; bhex = "⠠⠨⠥"; bdots = "6 + 46 + 136"; break; // Upper upsilon
                case 'Φ': braille += "\u2820\u2828\u280B"; bhex = "⠠⠨⠋"; bdots = "6 + 46 + 124"; break; // Upper phi
                case 'Χ': braille += "\u2820\u2828\u282F"; bhex = "⠠⠨⠯"; bdots = "6 + 46 + 12346"; break; // Upper chi
                case 'Ψ': braille += "\u2820\u2828\u283D"; bhex = "⠠⠨⠽"; bdots = "6 + 46 + 13456"; break; // Upper psi
                case 'Ω': braille += "\u2820\u2828\u283A"; bhex = "⠠⠨⠺"; bdots = "6 + 46 + 2456"; break; // Upper omega



                ///////////////////////////////////////////////////////////////////
                // General Symbols and Indicators
                ///////////////////////////////////////////////////////////////////

                case ',': braille += "\u283C\u2802"; bhex = "⠼⠂"; bdots = "3456 + 2"; break; //comma
                case '.': braille += "\u283C\u282A"; bhex = "⠼⠪"; bdots = "3456 + 246"; break; //full stop
                case ';': braille += "\u2806"; bhex = "⠆"; bdots = "23"; break; //semicolon
                case ':': braille += "\u2812"; bhex = "⠒"; bdots = "25"; break; //colon
                case '!': braille += "\u2816"; bhex = "⠖"; bdots = "235"; break; //exclamation mark
                                                                                 // case "...": braille += ""; bhex = ""; bdots = "256 + 256 + 256"; break; //ellipsis
                case '′': braille += "\u2836"; bhex = "⠶"; bdots = "2356"; break; //prime 
                case '″': braille += "\u2836\u2836"; bhex = "⠶⠶"; bdots = "2356 + 2356"; break; //double prime 
                case '→': braille += "\u2833\u2815"; bhex = "⠳⠕"; bdots = "1256 + 135"; break; //simple right pointing arrow (east) 
                case '↓': braille += "\u2833\u2829"; bhex = "⠳⠩"; bdots = "1256 + 146"; break; //simple down pointing arrow (south) 
                case '←': braille += "\u2833\u282A"; bhex = "⠳⠪"; bdots = "1256 + 246"; break; //simple left pointing arrow (west) 
                case '↑': braille += "\u2833\u282C"; bhex = "⠳⠬"; bdots = "1256 + 346"; break; //simple up pointing arrow (north) 
                case '∶': braille += "\u2812"; bhex = "⠒"; bdots = "25"; break; //ratio 
                case '∷': braille += "\u2812\u2812"; bhex = "⠒⠒"; bdots = "25 + 25"; break; //proportion 
                case '♮': braille += "\u283C\u2821"; bhex = "⠼⠡"; bdots = "3456 + 16"; break; //natural 
                case '♭': braille += "\u283C\u2823"; bhex = "⠼⠣"; bdots = "3456 + 126"; break; //flat 
                case '♯': braille += "\u283C\u2829"; bhex = "⠼⠩"; bdots = "3456 + 146"; break; //sharp 
                case '@': braille += "\u2808\u2801"; bhex = "⠈⠁"; bdots = "4 + 1"; break; //commercial at sign
                case '$': braille += "\u2808\u280E"; bhex = "⠈⠎"; bdots = "4 + 234"; break;
                case '£': braille += "\u2808\u2807"; bhex = "⠈⠇"; bdots = "4 + 123"; break;
                case '€': braille += "\u2808\u2811"; bhex = "⠈⠑"; bdots = "4 + 15"; break;
                case '¢': braille += "\u2808\u2809"; bhex = "⠈⠉"; bdots = "4 + 14"; break; //cent sign
                case '₣': braille += "\u2808\u280B"; bhex = "⠈⠋"; bdots = "4 + 124"; break; //French franc sign
                case '₦': braille += "\u2808\u281D"; bhex = "⠈⠝"; bdots = "4 + 1345"; break; //naira sign
                case '¥': braille += "\u2808\u283D"; bhex = "⠈⠽"; bdots = "4 + 13456"; break; //yen sign (yuan sign)
                case '^': braille += "\u2808\u2822"; bhex = "⠈⠢"; bdots = "4 + 26"; break; //caret 
                case '~': braille += "\u2808\u2814"; bhex = "⠈⠔"; bdots = "4 + 35"; break; //tilde (swung dash)
                case '†': braille += "\u2808\u2820\u2839"; bhex = "⠈⠠⠹"; bdots = "4 + 6 + 1456"; break; //dagger
                case '‡': braille += "\u2808\u2820\u283B"; bhex = "⠈⠠⠻"; bdots = "4 + 6 + 12456"; break; //double dagger
                case '©': braille += "\u2818\u2809"; bhex = "⠘⠉"; bdots = "45 + 14"; break; //copyright sign
                case '°': braille += "\u2818\u281A"; bhex = "⠘⠚"; bdots = "45 + 245"; break; //degree sign
                case '¶': braille += "\u2818\u280F"; bhex = "⠘⠏"; bdots = "45 + 1234"; break; //paragraph sign
                case '®': braille += "\u2818\u2817"; bhex = "⠘⠗"; bdots = "45 + 1235"; break; //registered sign
                case '§': braille += "\u2818\u280E"; bhex = "⠘⠎"; bdots = "45 + 234"; break; //section sign
                case '™': braille += "\u2818\u281E"; bhex = "⠘⠞"; bdots = "45 + 2345"; break; //trademark sign
                case '♀': braille += "\u2818\u282D"; bhex = "⠘⠭"; bdots = "45 + 1346"; break; //female sign (Venus)
                case '♂': braille += "\u2818\u283D"; bhex = "⠘⠽"; bdots = "45 + 13456"; break; //male sign (Mars)
                case '#': braille += "\u2838\u2839"; bhex = "⠸⠹"; bdots = "456 + 1456"; break; //number sign
                case '•': braille += "\u2838\u2832"; bhex = "⠸⠲"; bdots = "456 + 256"; break; //bullet
                case '〃': braille += "\u2810\u2802"; bhex = "⠐⠂"; bdots = "5 + 2"; break; //ditto mark
                case '+': braille += "\u2810\u2816"; bhex = "⠐⠖"; bdots = "5 + 235"; break; //plus sign
                case '=': braille += "\u2810\u2836"; bhex = "⠐⠶"; bdots = "5 + 2356"; break; //equals sign
                case '×': braille += "\u2810\u2826"; bhex = "⠐⠦"; bdots = "5 + 236"; break; //multiplication sign
                case '*': braille += "\u2810\u2814"; bhex = "⠐⠔"; bdots = "5 + 35"; break; //asterisk (star)
                case '÷': braille += "\u2810\u280C"; bhex = "⠐⠌"; bdots = "5 + 34"; break; //division sign 
                case '%': braille += "\u2828\u2834"; bhex = "⠨⠴"; bdots = "46 + 356"; break; //percent sign 
                case '&': braille += "\u2808\u2828"; bhex = "⠈⠨"; bdots = "4 + 46"; break; //AND
                case '↵': braille += "\u2833\u2832\u2829"; bhex = "⠳⠲⠩"; bdots = "1256 + 256 + 146"; break; //ENTER KEY = down arrow with sharp turn right
                case '‰': braille += "\u2839"; bhex = "⠹"; bdots = "1456"; break; //per mille sign, like a percent sign but with two zeros in the denominator
                case '฿': braille += "\u283C\u2839"; bhex = "⠼⠹"; bdots = "3456 + 1456"; break; //Thai Baht currency sign, B with vertical stroke through it
                case '❀': braille += "\u2808\u283C\u2839"; bhex = "⠈⠼⠹"; bdots = "4 + 3456 + 1456"; break; //flower symbol 
                case '?': braille += "\u2826"; bhex = "⠦"; bdots = "236"; break;



                ///////////////////////////////////////////////////////////////////
                // Modifiers
                /////////////////////////////////////////////////////////////////// 

                //These are above or below char so not sure what to do with them at the moment.

                /*
                case ' ̸ ': braille += "\u2808\u2821"; bhex = "⠈⠡"; bdots = "4 + 16"; break; //solidus (forward slash) overlay on following letter
                case '  ̶ ': braille += "\u2808\u2812"; bhex = "⠈⠒"; bdots = "4 + 25"; break; //horizontal stroke overlay on following letter
                case ' ̆ ': braille += "\u2808\u282C"; bhex = "⠈⠠"; bdots = "4 + 346"; break; //breve above following letter
                case ' ̄ ': braille += "\u2808\u2824"; bhex = "⠈⠤"; bdots = "4 + 36"; break; //macron above following letter
                case ' ̧ ': braille += "\u2818\u282F"; bhex = "⠘⠯"; bdots = "45 + 12346"; break; //cedilla below following letter
                case ' ̀ ': braille += "\u2818\u2821"; bhex = "⠘⠡"; bdots = "45 = 16"; break; //grave accent above following letter
                case ' ̂ ': braille += "\u2818\u2829"; bhex = "⠘⠩"; bdots = "45 = 146"; break; //circumflex above following letter
                case ' ̊ ': braille += "\u2818\u282B"; bhex = "⠘⠫"; bdots = "45 + 1246"; break; //ring (circle) above following letter
                case ' ̃ ': braille += "\u2818\u283B"; bhex = "⠘⠻"; bdots = "45 + 12456"; break; //tilde above following letter
                case ' ̈ ': braille += "\u2818\u2812"; bhex = "⠘⠒"; bdots = "45 + 25"; break; //diaeresis (umlaut) above following letter
                case ' ́ ': braille += "\u2818\u280C"; bhex = "⠘⠌"; bdots = "45 + 34"; break; //acute accent above following letter
                case ' ̌ ': braille += "\u2818\u282C"; bhex = "⠘⠬"; bdots = "45 + 346"; break; //caron (hacek, wedge) above following letter
                case ' ̸ ': braille += "\u2820\u2808\u2821"; bhex = "⠠⠈⠡"; bdots = "6 + 4 + 16"; break; //solidus (forward slash) overlay on following capital letter
                case ' ̶ ': braille += "\u2820\u2808\u2812"; bhex = "⠠⠈⠒"; bdots = "6 + 4 + 25"; break; //horizontal stroke overlay on following capital letter
                case ' ̆ ': braille += "\u2820\u2808\u282C"; bhex = "⠠⠈⠬"; bdots = "6 + 4 + 346"; break; //breve above following capital letter
                case ' ̄ ': braille += "\u2820\u2808\u2824"; bhex = "⠠⠈⠤"; bdots = "6 + 4  + 36"; break; //macron above following capital letter
                case ' ̧ ': braille += "\u2820\u2818\u282F"; bhex = "⠠⠘⠯"; bdots = "6 + 45 + 12346"; break; //cedilla below following capital letter
                case ' ̀ ': braille += "\u2820\u2818\u2821"; bhex = "⠠⠘⠡"; bdots = "6 + 45 + 16"; break; //grave accent above following capital letter
                case ' ̂ ': braille += "\u2820\u2818\u2829"; bhex = "⠠⠘⠩"; bdots = "6 + 45 + 146"; break; //circumflex above following capital letter
                case ' ̊ ': braille += "\u2820\u2818\u282B"; bhex = "⠠⠘⠫"; bdots = "6 + 45 + 1246"; break; //ring (circle) above following capital letter
                case ' ̃ ': braille += "\u2820\u2818\u283B"; bhex = "⠠⠘⠻"; bdots = "6 + 45 + 12456"; break; //tilde above following capital letter
                case ' ̈ ': braille += "\u2820\u2818\u2812"; bhex = "⠠⠘⠒"; bdots = "6 + 45 + 25"; break; //diaeresis (umlaut) above following capital letter
                case ' ́ ': braille += "\u2820\u2818\u280C"; bhex = "⠠⠘⠌"; bdots = "6 + 45 + 34"; break; //acute accent above following capital letter
                case ' ̌ ': braille += "\u2820\u2818\u282C"; bhex = "⠠⠘⠬"; bdots = "6 + 45 + 346"; break; //caron (hacek, wedge) above following capital letter
                */


                case ' ': braille = "\u2800"; break; // Space

                case '\r': braille = "\r"; break; //carriage return or enter
                case '\t': braille = "\t"; break; //horizontal tab
                case '\v': braille = "\v"; break; //vertical tab
                case '\n': braille = "\n"; break; //line feed
                case '\f': braille = "\f"; break; // form feed

                default: braille = value.ToString(); break;
            }

            return braille; // + " : Hex = " + bhex + " : Dots = " + bdots;
        }
    }
}
