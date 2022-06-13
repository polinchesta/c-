using Practice_26.Task_1.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_26.Task_1.InterFaces
{
    public interface IXmlWorker
    {
        void Load(string xmlDocPath);
        void Add(Auto parking);
        void Delete(string mark);
        Auto FindBy(string mark);
        List<Auto> GetAll();
    }
}
