using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ALATLAS.classes
{
    public class connection
    {

        string ftdata;
        public string conndata()
        {

            ftdata = "server= localhost; userId=root; password=1234; database=odb99;CHARSET=utf8";

            return ftdata;
        }


    }
}