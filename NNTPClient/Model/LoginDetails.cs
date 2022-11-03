﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNTPClient.Model
{
    public class LoginDetails {
        
        public string Server { get; init; }
        public string User { get; init; }
        public string Pass { get; init; }

        public LoginDetails(string server, string user, string pass) {
            Server = server;
            User = user;
            Pass = pass;
        }

    }
}
