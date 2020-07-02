using System;
using System.Data;

namespace Assignment
{
    internal class SqlCeDataAdapter
    {
        private object cmd;

        public SqlCeDataAdapter(object cmd)
        {
            this.cmd = cmd;
        }

        internal void Fill(DataSet ds)
        {
            throw new NotImplementedException();
        }
    }
}