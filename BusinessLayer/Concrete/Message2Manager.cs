﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Message2Manager:IMessage2Service
    {
        IMessage2Dal _message2dal;

        public Message2Manager(IMessage2Dal message2dal)
        {
            _message2dal = message2dal;
        }

        public List<Message2> GetInboxListByWriter(int id)
        {
            return _message2dal.GetInboxWithMessageByWriter(id);
        }

        public List<Message2> GetList()
        {
            return _message2dal.GetListAll();
        }

        public List<Message2> GetSendBoxListByWriter(int id)
        {
            return _message2dal.GetSendBoxWithMessageByWriter(id);
            
        }


        public void TAdd(Message2 t)
        {
            _message2dal.Insert(t);
        }

        public void TDelete(Message2 t)
        {
            throw new NotImplementedException();
        }

        public Message2 TGetById(int id)
        {
            return _message2dal.GetByID(id);
        }

        public void TUpdate(Message2 t)
        {
            throw new NotImplementedException();
        }
    }
}
