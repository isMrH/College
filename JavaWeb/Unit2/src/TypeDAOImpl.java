import java.util.ArrayList;
import java.util.List;


public class TypeDAOImpl extends BaseDAO implements TypeDAO{
	public List search(){
		List list=new ArrayList();
		String sql="select * from type";
		try{
			super.getConnection();
			pstm=con.prepareStatement(sql);
			rs=pstm.executeQuery();
			while(rs.next)){
				Type type=new Type();
				type.setTypeID(rs.getInt("typeID"));
				type.setTypeName(rs.getString("typeName"));
				list.add(type);
			}
		}catch(Exception e){
			e.printStackTrace();
		}finally{
			super.closeAll();
		}
		retrun list;
	}


}
