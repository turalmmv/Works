#include <iostream>
#include <cstring>
using namespace std;
void generateSquare(int n)
{
	int magicSquare[5][5], sum = 65;
	memset(magicSquare, 0, sizeof(magicSquare));
	int i = 2;
	int j = 4;

	for (int num = 1; num <= 25;) {
		if (i == -1 && j == 5)
		{
			j = 3;
			i = 0;
		}
		else {
			if (j == 5)
				j = 0;

			if (i < 0)
				i = 4;
		}
		if (magicSquare[i][j])
		{
			j -= 2;
			i++;
			continue;
		}
		else
			magicSquare[i][j] = num++;
		j++;
		i--;
	}

	cout << n << ":\nSum of each row or column= " << sum << ":\n\n";
	for (i = 0; i < 5; i++) {
		for (j = 0; j < 5; j++)
			cout << magicSquare[i][j] << " ";
		cout << endl;
	}
}

int main()
{
	int n;
	generateSquare(n);
	return 0;
}