/*
 * This template is valid both in C and in C++,
 * so you can expand it with code from both languages.
 * NOTE: it is recommended to use this even if you don't
 * understand the following code.
 */

#include <assert.h>
#include <stdio.h>

#define MAXN 1000000

// input data
int N;
int P[MAXN];
int max=0;
int somma=0;

int main() {
  //  uncomment the following lines if you want to read/write from files
    freopen("input0.txt", "r", stdin);
    freopen("output0.txt", "w", stdout);

  assert(1 == scanf("%d", &N));
  for (int i = 0; i < N; i++) assert(1 == scanf("%d", &P[i]));

  // insert your code here
  for(int i=0;i<N;i++){
  	if(i==0){
  		somma=P[i];
  		max=P[i];
	  }
	  else{
	  	if(P[i]>max){
	  		max=P[i];
	  		somma=somma+P[i];
		  }
	  }
  }

  printf("%d\n", somma);  // print the result
  return 0;
}
