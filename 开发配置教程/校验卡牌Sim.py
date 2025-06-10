#琴弦上的宇宙

import html
import os
import shutil
import time
import re

#各文件路径
file_simNewRootPath = f"{os.getcwd()}\\cardsNew\\"
file_simOldRootPath = f"{os.getcwd()}\\cards\\"

#读取最新已经定义函数的Sim
NewSimCardPath = {}
NewSimCardID = []
for root, dirs, files in os.walk(file_simNewRootPath):
    for file in files:
        card_id = file.replace('Sim_', '').replace('.cs', '')
        with open(os.path.join(root, file), "r", encoding='utf-8') as sim_file:
            sim_content = sim_file.read()
            if "public" not in sim_content:
                NewSimCardPath[str(card_id)]=os.path.join(root, file)
                continue
            NewSimCardID.append(str(card_id))
#for value in NewSimCardID:
#    print(value)

#读取之前已经定义函数的Sim
OldSimCardContext = {}
OldSimCardID = []
for root, dirs, files in os.walk(file_simOldRootPath):
    for file in files:
        card_id = file.replace('Sim_', '').replace('.cs', '')
        #print(card_id)
        with open(os.path.join(root, file), "r", encoding='utf-8') as sim_file:
            sim_content = sim_file.read()
            if "public" not in sim_content:
                continue
            OldSimCardContext[str(card_id)]=sim_content
            OldSimCardID.append(str(card_id))
#for value in OldSimCardID:
#    print(value)

#对比new里面是否遗漏old中的Sim
setNew=set(NewSimCardID)
setOld=set(OldSimCardID)
diff=setOld-setNew
for value in list(diff):
    if value in NewSimCardPath:
        with open(NewSimCardPath[value], "w", encoding='utf-8') as sim_file:
            sim_file.write(OldSimCardContext[value])
            print(f"diff-{value}")