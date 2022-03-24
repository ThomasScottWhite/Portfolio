xLength = 10
yLength = 20
grid = []
import os
import time
clear = lambda: os.system('cls') #Magic that clears the console screen called by using clear()

def Tetris():
    Clear()
    for i in range(0,xLength):
        grid[19][i] = 1
    
    while(True):
        Display()
        time.sleep(1)

#blocks
# ####
#   #
#  ###
def Clear():
    for i in range(0,yLength):
        grid.append([])
        for k in range(0,xLength):
            grid[i].append(0)

def Display():
    clear()
    
    for i in range(0,yLength):
        print(grid[i])
        for k in range(0,xLength):
            1+1
Tetris()
