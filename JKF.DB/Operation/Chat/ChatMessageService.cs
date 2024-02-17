﻿using JKF.DB.DbContexts;
using JKF.DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JKF.DB.Operation
{
    public class ChatMessageService : BaseService<ChatMessage>
    {
        public ChatMessageService(BaseDbContext baseDbContext) : base(baseDbContext) { }
    }
}