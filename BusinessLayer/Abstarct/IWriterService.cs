using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstarct
{
    public interface IWriterService
    {
        List<Writer> Getlist();
        void WriterAdd(Writer writer);
        void WriterDelete(Writer writer);
        void WritrUpdate(Writer writer);    
        Writer GetByID(int id);
    }
}
