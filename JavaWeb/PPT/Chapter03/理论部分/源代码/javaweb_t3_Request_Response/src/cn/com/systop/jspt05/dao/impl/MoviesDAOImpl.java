package cn.com.systop.jspt05.dao.impl;

import java.util.ArrayList;
import java.util.List;

import cn.com.systop.jspt05.dao.MoviesDAO;
import cn.com.systop.jspt05.entity.Movies;

public class MoviesDAOImpl extends BaseDAO implements MoviesDAO {

	// ��ӰDVD��ӷ���
	public int save(Movies movies) {
		int row = 0;
		String sql = "INSERT INTO movies(moviename,director,typeid,stardom,region,showtime,description,image,price) VALUES(?,?,?,?,?,?,?,?,?)";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			// �������������ֵ
			pstm.setString(1, movies.getMovieName());
			pstm.setString(2, movies.getDirector());
			pstm.setInt(3, movies.getTypeID());
			pstm.setString(4, movies.getStardom());
			pstm.setString(5, movies.getRegion());
			pstm.setString(6, movies.getShowtime());
			pstm.setString(7, movies.getDescription());
			pstm.setString(8, movies.getImage());
			pstm.setDouble(9, movies.getPrice());
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��ӰDVD���·���
	public int update(Movies movies) {
		int row = 0;
		String sql = "UPDATE movies SET movieName = ? WHERE movieID = ?";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			// �������������ֵ
			pstm.setString(1, movies.getMovieName());
			pstm.setInt(2, movies.getMovieID());
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��ӰDVDɾ������
	public int delete(int movieID) {
		int row = 0;
		String sql = "DELETE FROM movies WHERE movieID = ?";// �����������SQL���
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			pstm.setInt(1, movieID);// �������������ֵ
			row = pstm.executeUpdate();// ִ��SQL���,������Ӱ�������
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return row;// ������Ӱ�������
	}

	// ��ӰDVD��ѯ����
	public List search(int pageNo, int typeID) {
		List list = new ArrayList();// ���������ӰDVD�б�
		int pageSize = 10;// ÿҳ����¼��
		int rows = 0;// ��ʾÿҳ֮ǰ�ļ�¼��
		if (pageNo > 1) {
			// ����ÿҳ֮ǰ��¼���������2ҳ֮ǰ��¼��Ϊ��2-1��*10=10��
			rows = (pageNo - 1) * pageSize;
		}
		/*String sql = "SELECT top " + pageSize + " * FROM movies WHERE typeID="
				+ typeID + " AND movieID not in(select top " + rows
				+ " movieID from " + "movies where typeID=" + typeID
				+ " order by movieID) ORDER BY movieID";// SQL���
		*/
		String sql="select * from movies where typeid="+typeID+" limit "+rows+","+pageSize;
		try {
			super.getConnection();// ���ø��෽����ȡ���ݿ�����
			pstm = con.prepareStatement(sql);// ����Ԥ�����SQL������
			rs = pstm.executeQuery();// ִ��sql���,���ؽ����
			while (rs.next()) {
				// ���������������ӰDVD�����װ����
				Movies movies = new Movies();
				movies.setMovieID(rs.getInt("movieID"));
				movies.setMovieName(rs.getString("movieName"));
				movies.setDirector(rs.getString("director"));
				movies.setTypeID(rs.getInt("typeID"));
				movies.setStardom(rs.getString("stardom"));
				movies.setRegion(rs.getString("region"));
				movies.setShowtime(rs.getString("showtime"));
				movies.setImage(rs.getString("image"));
				movies.setDescription(rs.getString("description"));
				movies.setPrice(rs.getDouble("price"));
				// ����ӰDVD������ӵ�ArrayList������
				list.add(movies);
			}
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			super.closeAll();// �ͷ����ݿ���Դ
		}
		return list;
	}
}
