#琴弦上的宇宙

import xml.etree.ElementTree as ET
import html
import os
import shutil
import time
import re

#各文件路径
file_cardDefsPath =     f"{os.getcwd()}\\CardDefs.xml"

# 要删除的子节点的标签名称列表
nodes_to_remove = ['deDE','esES','esMX','frFR','itIT','jaJP','koKR','plPL','ptBR','ruRU','thTH','zhTW']

# 保存修改后的XML文件
def DeleteNode(deleteNode):
    tree = ET.parse(file_cardDefsPath)
    root = tree.getroot()
    for Entity in root.findall('Entity'):
        for Tag in Entity.findall('Tag'):
            for node in Tag:
                if node.tag in deleteNode:
                    Tag.remove(node)
    tree.write(file_cardDefsPath, encoding='utf-8', xml_declaration=True)

DeleteNode(nodes_to_remove)
