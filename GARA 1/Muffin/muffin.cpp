/*
 * This template is valid both in C and in C++,
 * so you can expand it with code from both languages.
 */

#include <stdio.h>
#include <assert.h>
#include <iostream>
// constraints
#define MAXN 1000000

using namespace std;
// input data
int N, K, i;
int T[MAXN]={1,-2, 4, -8, 16};
int massimo,somma=0;
int minimo=0;
int main() {
	cout<<"N";
	cin>>N;
	cout<<"K";
	cin>>K;

//  uncomment the following lines if you want to read/write from files
  /*freopen("muffin.input1.txt", "r", stdin);
 freopen("muffin.output1.txt", "w", stdout);

    assert(2 == scanf("%d %d", &N, &K));
    for (i = 0; i < N; i++)
        assert(1 == scanf("%d", &T[i]));*/

    // insert your code here
    
    
   for(int a=0;a<N-(K-1);a++){
   	somma=0;
   	
   	for(int j=0;j<K;j++){
   		somma=somma +T[a+j];
	   }
	   
	   if(a=0){
   	massimo=somma;
	   }
	   else{
	   	if(massimo<somma){
	   		massimo=somma;
		   }
	   }
	   
   }
    

  //  printf("%d\n", massimo); // change 42 with actual answer
  cout<<massimo;
    return 0;
}

