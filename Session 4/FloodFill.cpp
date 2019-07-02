/* 
 * File:   Oil Deposites.cpp
 * Author: ubuntu
 *
 * Created on April 25, 2015, 7:37 PM
 */

#include <cstdlib>
#include<string>
#include<iostream>
#include <vector>
#include<cstdio>
#include<cstring>
using namespace std;

/*
 * 
 */
int n,m;
vector<string>v;
int visited[101][101];
void flood_fill(int x,int y){
    if(visited[x][y])
        return;
    visited[x][y]=1;
    if(x>0 && v[x-1][y]=='@')
        flood_fill(x-1,y);
    if(y>0 && v[x][y-1]=='@')
        flood_fill(x,y-1);
    if(x+1<n && v[x+1][y]=='@')
        flood_fill(x+1,y);
    if(y+1<m && v[x][y+1]=='@')
        flood_fill(x,y+1);
    
    if(x>0 && y>0 && v[x-1][y-1]=='@')
        flood_fill(x-1,y-1);
    if(x>0 && y+1<m && v[x-1][y+1]=='@')
        flood_fill(x-1,y+1);
    if(x+1<n && y>0 && v[x+1][y-1]=='@')
        flood_fill(x+1,y-1);
    if(x+1<n && y+1<m && v[x+1][y+1]=='@')
        flood_fill(x+1,y+1);
}

void init(){
    for (int i = 0; i < 101; i++) {
        for (int j = 0; j < 101; j++) {
            visited[i][j]=0;
        }
    }
    v.clear();
}
int main(int argc, char** argv) {

    freopen("in.in","r",stdin);
    while(cin>>n>>m && (n||m)){
        string s;
        init();
        for(int i=0;i<n;i++){
            cin>>s;
            v.push_back(s);
        }
        int counter=0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if(v[i][j]=='@' && !visited[i][j]){
                    flood_fill(i,j);
                    counter++;
                }
            }
        }
        cout<<counter<<endl;
    }
    return 0;
}