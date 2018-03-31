package cn.com.systop.t02;

public class JavaBeanIndex {
	// dataSet是一个index属性
	private int[] dataSet ={1,2,3,4,5,6};

	public JavaBeanIndex() {
	}

	// set整个数组
	public void setDataSet(int[] x) {
		dataSet = x;
	}

	// set数组中的单个元素值
	public void setDataSet(int index, int x) {
		dataSet[index] = x;
	}

	// get整个数组值
	public int[] getDataSet() {
		return dataSet;
	}

	// get数组中的指定元素值
	public int getDataSet(int x) {
		return dataSet[x];
	}
}
