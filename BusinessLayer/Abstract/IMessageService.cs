﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService:IGenericService<Message>
    {

        public List<Message> GetInboxListByWriter(string p);
        public List<Message> GetSendBoxListByWriter(string p);
    }
}
