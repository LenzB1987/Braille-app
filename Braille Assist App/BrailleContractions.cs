using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille_Assist_App
{
    internal class BrailleContractions
    {
        static public string ToBrailleContractions(string value)
        {
            string braille = "";
            string bhex = "";
            string bdots = "";

            switch (value)
            {
                ///////////////////////////////////////////////////////////////////
                // Contractions - Alphabetic word signs
                ///////////////////////////////////////////////////////////////////
                // May need to do the check when we read the data and put it through as the character rather than string

                // a is already stand alone
                case "but": braille += "\u2803"; bhex = "⠃"; bdots = "12"; break;
                case "can": braille += "\u2809"; bhex = "⠉"; bdots = "14"; break;
                case "do": braille += "\u2819"; bhex = "⠙"; bdots = "145"; break;
                case "every": braille += "\u2811"; bhex = "⠑"; bdots = "15"; break;
                case "from": braille += "\u280B"; bhex = "⠋"; bdots = "124"; break;
                case "go": braille += "\u281B"; bhex = "⠛"; bdots = "1245"; break;
                case "have": braille += "\u2813"; bhex = "⠓"; bdots = "125"; break;
                // I is already stand alone
                case "just": braille += "\u281A"; bhex = "⠚"; bdots = "245"; break;
                case "knowledge": braille += "\u2805"; bhex = "⠅"; bdots = "13"; break;
                case "like": braille += "\u2807"; bhex = "⠇"; bdots = "123"; break;
                case "more": braille += "\u280D"; bhex = "⠍"; bdots = "134"; break;
                case "not": braille += "\u281D"; bhex = "⠝"; bdots = "1345"; break;
                // o not sure why not
                case "people": braille += "\u280F"; bhex = "⠏"; bdots = "1234"; break;
                case "quite": braille += "\u281F"; bhex = "⠟"; bdots = "12345"; break;
                case "rather": braille += "\u2817"; bhex = "⠗"; bdots = "1235"; break;
                case "so": braille += "\u280E"; bhex = "⠎"; bdots = "234"; break;
                case "that": braille += "\u281E"; bhex = "⠞"; bdots = "2345"; break;
                case "us": braille += "\u2825"; bhex = "⠥"; bdots = "136"; break;
                case "very": braille += "\u2827"; bhex = "⠧"; bdots = "1236"; break;
                case "will": braille += "\u283A"; bhex = "⠺"; bdots = "2456"; break;
                case "it": braille += "\u282D"; bhex = "⠭"; bdots = "1346"; break;
                case "you": braille += "\u283D"; bhex = "⠽"; bdots = "13456"; break;
                case "as": braille += "\u2835"; bhex = "⠵"; bdots = "1356"; break;

                ///////////////////////////////////////////////////////////////////
                // Strong word signs when word is stand alone
                ///////////////////////////////////////////////////////////////////                   
                case "child": braille += "\u2821"; bhex = "⠡"; bdots = "16"; break;
                case "shall": braille += "\u2829"; bhex = "⠩"; bdots = "146"; break;
                case "this": braille += "\u2839"; bhex = "⠹"; bdots = "1456"; break;
                case "which": braille += "\u2831"; bhex = "⠱"; bdots = "156"; break;
                case "out": braille += "\u2833"; bhex = "⠳"; bdots = "1256"; break;
                case "still": braille += "\u280C"; bhex = "⠌"; bdots = "34"; break;

                ///////////////////////////////////////////////////////////////////
                // Strong word signs when occurs as part of word
                ///////////////////////////////////////////////////////////////////
                case "and": braille += "\u282F"; bhex = "⠯"; bdots = "12346"; break;
                case "for": braille += "\u283F"; bhex = "⠿"; bdots = "123456"; break;
                case "of": braille += "\u2837"; bhex = "⠷"; bdots = "12356"; break;
                case "the": braille += "\u282E"; bhex = "⠮"; bdots = "2346"; break;
                case "with": braille += "\u283E"; bhex = "⠾"; bdots = "23456"; break;


                case "ch": braille += "\u2821"; bhex = "⠡"; bdots = "16"; break;
                case "gh": braille += "\u2823"; bhex = "⠣"; bdots = "126"; break;
                case "sh": braille += "\u2829"; bhex = "⠩"; bdots = "146"; break;
                case "th": braille += "\u2839"; bhex = "⠹"; bdots = "1456"; break;
                case "wh": braille += "\u2831"; bhex = "⠱"; bdots = "156"; break;
                case "ed": braille += "\u282B"; bhex = "⠫"; bdots = "1246"; break;
                case "er": braille += "\u283B"; bhex = "⠻"; bdots = "12456"; break;
                case "ou": braille += "\u2833"; bhex = "⠳"; bdots = "1256"; break;
                case "ow": braille += "\u282A"; bhex = "⠪"; bdots = "246"; break;
                case "st": braille += "\u280C"; bhex = "⠌"; bdots = "34"; break;
                case "ing": braille += "\u282C"; bhex = "⠬"; bdots = "346"; break;
                case "ar": braille += "\u281C"; bhex = "⠜"; bdots = "345"; break;

                ///////////////////////////////////////////////////////////////////
                // Lower word signs - stand alone without punctuation
                /////////////////////////////////////////////////////////////////// 
                case "enough": braille += "\u2822"; bhex = "⠢"; bdots = "26"; break;
                case "were": braille += "\u2836"; bhex = "⠶"; bdots = "2356"; break;
                case "his": braille += "\u2826"; bhex = "⠦"; bdots = "236"; break;
                case "was": braille += "\u2834"; bhex = "⠴"; bdots = "356"; break;


                ///////////////////////////////////////////////////////////////////
                // Lower group signs - as part of a word
                ///////////////////////////////////////////////////////////////////
                case "ea": braille += "\u2802"; bhex = "⠂"; bdots = "2"; break;
                case "bb": braille += "\u2806"; bhex = "⠆"; bdots = "23"; break;
                case "con": braille += "\u2812"; bhex = "⠒"; bdots = "25"; break;
                case "cc": braille += "\u2812"; bhex = "⠒"; bdots = "25"; break;
                case "dis": braille += "\u2832"; bhex = "⠲"; bdots = "256"; break;
                case "en": braille += "\u2822"; bhex = "⠢"; bdots = "26"; break;
                case "ff": braille += "\u2816"; bhex = "⠖"; bdots = "235"; break;
                case "gg": braille += "\u2836"; bhex = "⠶"; bdots = "2356"; break;

                ///////////////////////////////////////////////////////////////////
                // Lower group signs - can be both of above two
                ///////////////////////////////////////////////////////////////////
                case "be": braille += "\u2806"; bhex = "⠆"; bdots = "23"; break;
                case "in": braille += "\u2814"; bhex = "⠔"; bdots = "35"; break;









                default: braille = value; break;
            }

            return braille;

        }


    

}
}
