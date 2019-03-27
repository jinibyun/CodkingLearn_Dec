using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWebApi
{
    public class pubsRepository
    {
        public title GetTitles()
        {
            using (var context = new pubsEntities())
            {
                return context.titles.AsEnumerable().FirstOrDefault();
            }
        }
        public void GetTitles(string titleId)
        {
            //using (var context = new pubsEntities())
            //{
            //    return context.titles.wh;
            //}
        }
    }
}