using System.Windows.Forms;

namespace quanlyxekhach.StrateryPattern
{
    public class MyTextBox : TextBox
    {
        public ValidationType validationType = ValidationType.INTERGER;
        public Ivalidation ivalidation = new IntValid();

        public Ivalidation CreateValidator()
        {
            switch (validType)
            {
                case ValidationType.FLOAT:
                    return new FloatValid();

                case ValidationType.EMAIL:
                    return new EmailValid();

                case ValidationType.PHONE:
                    return new PhoneValid();

                case ValidationType.DATE:
                    return new DatetimeValid();

                case ValidationType.STRING:
                    return new StringValid();

                default:
                    return new IntValid();
            }
        }

        public ValidationType validType
        {
            get => validationType;
            set
            {
                validationType = value;
                ivalidation = CreateValidator();
            }
        }

        public bool Validate()
        {
            return ivalidation.valid(Text);
        }
    }
}