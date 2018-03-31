import java.util.Scanner;

import cn.com.ambow.logic.Calculator;

public class Main {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner sc = new Scanner(System.in);
		System.out.println("请输入一个数：");
		int num1 = sc.nextInt();
		System.out.println("再请输入一个数：");
		sc = new Scanner(System.in);
		int num2 = sc.nextInt();
		System.out.println("请输入一个运算符号：");
		sc = new Scanner(System.in);
		char operator = sc.nextLine().charAt(0);
		System.out.print("运算结果为：");
		switch (operator) {
		case '+':
			System.out.println(num1 + num2);
			break;
		case '-':
			System.out.println(num1 - num2);
			break;
		case '*':
			System.out.println(num1 * num2);
			break;
		case '/':
			System.out.println(num1 / num2);
			break;
		case '%':
			System.out.println(num1 % num2);
			break;
		}
		// 考虑到代码重用性，可以将计算功能封装在方法里。
//		int rst = new Calculator().comput(num1, num2, operator);
//		System.out.println(rst);

	}

}
