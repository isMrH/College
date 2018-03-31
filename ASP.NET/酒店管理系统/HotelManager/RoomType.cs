using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Model
{
    public class RoomType
    {
        int typeId;

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        int typePrice;

        public int TypePrice
        {
            get { return typePrice; }
            set { typePrice = value; }
        }
        string isAddBed;

        public string IsAddBed
        {
            get { return isAddBed; }
            set { isAddBed = value; }
        }
        int addBedPrice;

        public int AddBedPrice
        {
            get { return addBedPrice; }
            set { addBedPrice = value; }
        }
        string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
