package cn.com.ambow.logic;

public class Calculator {
	
	/**
	 * 计算器的四则运算方法
	 * @param num1 参数1
	 * @param num2 参数2
	 * @param operator 运算符
	 * @return 运算结果
	 */
	public int comput(int num1, int num2, char operator) {
		int rst = 0;
		switch (operator) {
		case '+':
			rst = num1 + num2;
			break;
		case '-':
			rst = num1 - num2;
			break;
		case '*':
			rst = num1 * num2;
			break;
		case '/':
			rst = num1 / num2;
			break;
		case '%':
			rst = num1 % num2;
			break;
		}
		return rst;
	}

}
