using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blazor2.Services
{
    public interface ITakeMessageService
    {
        string take();
    }

    public class TakeMessageByPhone : ITakeMessageService
    {
        public string take()
        {
            return "Сообщение отправлено через телефон";
        }
    }

    public class TakeMessageByComputer : ITakeMessageService
    {
        public string take()
        {
            return "Сообщение отправлено через компьютер";
        }
    }
}
