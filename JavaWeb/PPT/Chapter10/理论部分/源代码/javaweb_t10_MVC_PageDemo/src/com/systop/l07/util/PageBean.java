package com.systop.l07.util;

public class PageBean {
	public int maxPage; // 一共有多少页
	public int maxRowCount; // 一共有多少行
	public static int pagesize = 3; // 每页多少行

	public PageBean() {
	}
	/**
	 * 得到总页数
	 * @return 返回总页数
	 * @throws Exception
	 */
	public int countPage() throws Exception {
		int maxRowCount = this.MaxCount();
		if (maxRowCount % this.pagesize == 0) {
			maxPage = maxRowCount / this.pagesize;
		} else {
			maxPage = maxRowCount / this.pagesize + 1;
		}
		return maxPage;
	}

	/**
	 * 得到总行数
	 * @return 返回总行数
	 * @throws Exception
	 */
	public int MaxCount() throws Exception {
		ContactBean contact = new ContactBean();
		this.maxRowCount = contact.getAvailableCount(); // 得到总行数
		return maxRowCount;
	}

}
