using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Model
{
    public class RoomType
    {
        int typeID;

        public int TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        float typePrice;

        public float TypePrice
        {
            get { return typePrice; }
            set { typePrice = value; }
        }
        float addBedPrice;

        public float AddBedPrice
        {
            get { return addBedPrice; }
            set { addBedPrice = value; }
        }
        string isAddBed;

        public string IsAddBed
        {
            get { return isAddBed; }
            set { isAddBed = value; }
        }
        string remark;

        public string Remark
        {
            get { return remark; }
            set { remark = value; }
        }
    }
}
