using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dp_test.Interfaces
{
    public interface IUserInterface
    {
        string PromptUser();

        string ReadInput();

        void ErrorMessage();
    }
}