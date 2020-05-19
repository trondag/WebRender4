using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebRender4.WebRender;

namespace WebRender.WebRender.HTMLelements
{
    public enum InputType
    {

        TEXT_INPUT,
        NUMBER_INPUT,
        SUBMIT_INPUT,
        EMAIL_INPUT,
        BUTTON_INTPUT,
        COLOR_INPUT,
        DATE_INPUT
    }
    public class InputTag : CompositeTag
    {
        private string inputType;
        public InputTag(InputType inputType, string placeHolder)
        {
            context = "input";
            hasClosingTag = false;
            placeholder = placeHolder;

            switch (inputType)
            {
                case InputType.TEXT_INPUT:
                    this.inputType = "text";
                    break;
                case InputType.NUMBER_INPUT:
                    this.inputType = "number";
                    break;
                case InputType.SUBMIT_INPUT:
                    this.inputType = "submit";
                    break;
                case InputType.EMAIL_INPUT:
                    this.inputType = "email";
                    break;
                case InputType.BUTTON_INTPUT:
                    this.inputType = "button";
                    break;
                case InputType.COLOR_INPUT:
                    this.inputType = "color";
                    break;
                case InputType.DATE_INPUT:
                    this.inputType = "date";
                    break;
            }
        }
        public string getInputType()
        {
            return inputType;
        }
    }
}
