using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Braille_Assist_App
{
    internal class braillemodes
    {
        public braillemodes()
        {
            /////////////////////////////////////////////////////////////////////
            // Modes  determines the meaning of the braille signs which follow
            /////////////////////////////////////////////////////////////////////**
            
                 // \u282B = ⠫ = 1246 = Sets Shape Mode
                 // \u2833 = ⠳ = 1256 = Sets Arrow Mode
                 // \u283C = ⠼ = 3456 = Sets Numeric
                //  \u2810 + \u2812 = ⠐⠒ = 5 + 25 = Opens and Sets Start Horizontal Line

               //   \u2830 = ⠰ = 56 =  grade 1 symbol indicator
              //    \u2830\u2830 = ⠰⠰ = 56 + 56 =  grade 1 word indicator
               //   \u2830\u2830\u2830 = ⠰⠰⠰ = 56 + 56 + 56 =  grade 1 passage indicator
               //   \u2830\u2804 = ⠰⠄ = 56 + 3 = grade 1 terminator
             //


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
             * special prefix may be used in combination with another
               special prefix to form a braille sign. Such braille signs are used only
               as indicators.

             * \u2830 = ⠰ = 56
             * \u2820 = ⠠ = 6
             */


            /////////////////////////////////////////////////////////////////////
            // Prefix change aspect of following character e.g. make superscript
            /////////////////////////////////////////////////////////////////////
            /*               

               \u2822 = ⠢ = 26 = subscript indicator
               \u2814 = ⠔ = 35 = superscript indicator

               \u2818\u2816 = ⠘⠖ = 45 + 235 = ligature indicator

               \u2828\u2806 = ⠨⠆ = 46 + 23 = italic symbol indicator
               \u2828\u2802 = ⠨⠂ = 46 + 2 = italic word indicator
               \u2828\u2836 = ⠨⠶ = 46 + 2356 = italic passage indicator
               \u2828\u2804 = ⠨⠄ = 46 + 3 = italic terminator

               \u2818\u2806 = ⠘⠆ = 45 + 23 = bold symbol indicator
               \u2818\u2802 = ⠘⠂ = 45 + 2 = boldface word indicator
               \u2818\u2836 = ⠘⠶ = 45 + 2356 = boldface passage indicator
               \u2818\u2804 = ⠘⠄ = 45 + 3 = boldface terminator

               \u2838\u2806 = ⠸⠆ = 456 + 23 = underlined symbol indicator
               \u2838\u2802 = ⠸⠂ = 456 + 2 = underlined word indicator
               \u2838\u2836 = ⠸⠶ = 456 + 2356 = underlined passage indicator
               \u2838\u2804 = ⠸⠄ = 456 + 3 = underlined terminator

               \u2808\u2806 = ⠈⠆ = 4 + 23 = script symbol indicator
               \u2808\u2802 = ⠈⠂ = 4 + 2 = script word indicator
               \u2808\u2836 = ⠈⠶ = 4 + 2356 = script passage indicator
               \u2808\u2804 = ⠈⠄ = 4 + 3 = script terminator

               \u2808\u283C\u2806 = ⠈⠼⠆ = 4 + 3456 + 23 = first transcriber-defined typeform symbol indicator
               \u2808\u283C\u2802 = ⠈⠼⠂ = 4 + 3456 + 2 = first transcriber-defined typeform word indicator
               \u2808\u283C\u2836 = ⠈⠼⠶ = 4 + 3456 + 2356 = first transcriber-defined typeform passage indicator
               \u2808\u283C\u2804 = ⠈⠼⠄ = 4 + 3456 + 3 = first transcriber-defined typeform terminator

               \u2818\u283C = ⠘⠼ = 45 + 3456 = prefix for second transcriber-defined typeform
               \u2838\u283C = ⠸⠼ = 456 + 3456 = prefix for third transcriber-defined typeform
               \u2810\u283C = ⠐⠼ = 5 + 3456 = prefix for fourth transcriber-defined typeform
               \u2828\u283C = ⠨⠼= 46 + 3456 = prefix for fifth transcriber-defined typeform

               \u2820 = ⠠ = 6 = capitals letter indicator
               \u2820\u2820 = ⠠⠠ = 6 + 6 = capitals word indicator                   
               \u2820\u2820\u2820 = ⠠⠠⠠ = 6 + 6 + 6 = capitals passage indicator
               \u2820\u2804 = ⠠⠄ = 6 + 3 = capitals terminator

             */

            /////////////////////////////////////////////////////////////////////
            // Other indicators
            /////////////////////////////////////////////////////////////////////
            /*
               \u283F = ⠿ = 123456 = cursor indicator

               \u2837 = ⠷ = 12356 = general fraction open indicator
               \u283E = ⠾ = 23456 = general fraction close indicator

               \u2823 = ⠣ = 126 = braille grouping opening indicator
               \u281C = ⠜ = 345 = braille grouping closing indicator

               \u2808\u2828\u2823 = ⠈⠨⠣ = 4 + 46 + 126 = transcriber's note opening indicator
               \u2808\u2828\u281C = ⠈⠨⠜ = 4 + 46 + 345 = transcriber's note closing indicator

               \u2818\u2837 = ⠘⠷ = 45 + 12356 = non-UEB word indicator
               \u2838 = ⠸ = 456 = line indicator Scansion, Stress and Tone
               \u2810 = ⠐ = 5 = line continuation indicator Numeric Mode
               \u2810\u2810\u283F = ⠐⠐⠿ = 5 + 5 + 123456 = dot locator for "use" 
               \u2828\u283F = ⠨⠿ = 46 + 123456 = dot locator for "mention" 

               \u2839 = ⠹ = 1456 = first transcriber-defined print symbol
               \u283C\u2839 = ⠼⠹ = 3456 + 1456 = second transcriber-defined print symbol
               \u2808\u283C\u2839 = ⠈⠼⠹ = 4 + 3456 + 1456 = third transcriber-defined print symbol
               \u2818\u283C\u2839 = ⠘⠼⠹ = 45 + 3456 + 1456 = fourth transcriber-defined print symbol
               \u2838\u283C\u2839 = ⠸⠼⠹ = 456 + 3456 + 1456 = fifth transcriber-defined print symbol
               \u2810\u283C\u2839 = ⠐⠼⠹ = 5 + 3456 + 1456 = sixth transcriber-defined print symbol
               \u2828\u283C\u2839 = ⠨⠼⠹ = 46 + 3456 + 1456 = seventh transcriber-defined print symbol

               \u2820\u2818\u2838\u2802 = ⠠⠘⠸⠂ = 6 + 45 + 456 + 2 = first transcriber-defined modifier on following capital letter
               \u2820\u2818\u2838\u2806 = ⠠⠘⠸⠆ = 6 + 45 + 456 + 23 = second transcriber-defined modifier on following capital letter
               \u2820\u2818\u2838\u2824 = ⠠⠘⠸⠤ = 6 + 45 + 456 + 36 = third transcriber-defined modifier on following capital letter
               \u2818\u2838\u2802 = ⠘⠸⠂ = 45 + 456 + 2 = first transcriber-defined modifier on following letter
               \u2818\u2838\u2806 = ⠘⠸⠆ = 45 + 456 + 23 = second transcriber-defined modifier on following letter
               \u2818\u2838\u2824 = ⠘⠸⠤ = 45 + 456 + 36 = third transcriber-defined modifier on following letter

            */
        }
    }
}