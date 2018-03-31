import java.util.List;



public interface TypeDAO {
	public int save(Type type);
	public int update(Type type);
	public int delete(int typeID);
	public List search();
}