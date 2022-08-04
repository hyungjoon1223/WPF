using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace WpfApp1.Model
{
    public class ViewModel : Notifier
    {
        string lastName = string.Empty;//성
        string firstName = string.Empty;//명
        string fullName = string.Empty;//성명
        string birth = string.Empty;
        bool isBirthError = false;

        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                fullName = lastName + firstName;
                //이름 및 성명전체를 수정합니다.
                NotifyChanged("LastName", "FullName");
                //NotifyChanged("LastName");
                //NotifyChanged("FullName");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                fullName = lastName + firstName;
                //성 및 성명전체를 수정합니다.
                NotifyChanged("FirstName", "FullName");
            }
        }

        public string FullName
        {
            get { return fullName; }
        }

        public string Birth
        {
            get { return birth; }
            set
            {
                if (Regex.IsMatch(value, "^[0-9]*$"))
                {
                    birth = value;
                    isBirthError = false;
                }
                else
                {
                    //birth = value;
                    birth = value;
                    isBirthError = true;
                }
                NotifyChanged("Birth");
                NotifyChanged("BirthErr");
                NotifyChanged("BirthErrMsg");
            }
        }

        public bool BirthErr
        {
            get
            {
                return isBirthError;
            }
        }

        public string BirthErrMsg
        {
            get
            {
                if (!isBirthError)
                    return $"입력하신 생년월일 : {birth}";
                else
                    return $"생년월일은 숫자로 입력해 주세요 : {birth}";
            }
        }
    }
}

