#琴弦上的宇宙

import html
import os
import shutil
import time
import re

class TAG_CARDTYPE_ENUM:
    INVALID=0
    GAME=1
    PLAYER=2
    HERO=3
    MINION=4
    SPELL=5
    ENCHANTMENT=6
    WEAPON=7
    ITEM=8
    TOKEN=9
    HERO_POWER=10
    BLANK=11
    GAME_MODE_BUTTON=12
    MOVE_MINION_HOVER_TARGET=22
    LETTUCE_ABILITY=23
    BATTLEGROUND_HERO_BUDDY=24
    LOCATION=39
    BATTLEGROUND_QUEST_REWARD=40
    BATTLEGROUND_ANOMALY=43
    BATTLEGROUND_SPELL=42
    BATTLEGROUND_TRINKET = 44
    BATTLEGROUND_CLICKABLE_BUTTON = 46
TAG_CARDTYPE = {
    TAG_CARDTYPE_ENUM.INVALID:                  "无效的",
    TAG_CARDTYPE_ENUM.GAME:                     "GAME",
    TAG_CARDTYPE_ENUM.PLAYER:                   "PLAYER",
    TAG_CARDTYPE_ENUM.HERO:                     "英雄",
    TAG_CARDTYPE_ENUM.MINION:                   "随从",
    TAG_CARDTYPE_ENUM.SPELL:                    "法术",
    TAG_CARDTYPE_ENUM.ENCHANTMENT:              "附魔",
    TAG_CARDTYPE_ENUM.WEAPON:                   "武器",
    TAG_CARDTYPE_ENUM.ITEM:                     "ITEM",
    TAG_CARDTYPE_ENUM.TOKEN:                    "TOKEN",
    TAG_CARDTYPE_ENUM.HERO_POWER:               "英雄技能",
    TAG_CARDTYPE_ENUM.BLANK:                    "空白",
    TAG_CARDTYPE_ENUM.GAME_MODE_BUTTON:         "GAME_MODE_BUTTON",
    TAG_CARDTYPE_ENUM.MOVE_MINION_HOVER_TARGET: "MOVE_MINION_HOVER_TARGET",
    TAG_CARDTYPE_ENUM.LETTUCE_ABILITY:          "LETTUCE_ABILITY",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_HERO_BUDDY:  "BATTLEGROUND_HERO_BUDDY",
    TAG_CARDTYPE_ENUM.LOCATION:                 "地标",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_QUEST_REWARD:"BATTLEGROUND_QUEST_REWARD",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_ANOMALY:     "BATTLEGROUND_ANOMALY",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_SPELL:       "BATTLEGROUND_SPELL",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_TRINKET:       "BATTLEGROUND_TRINKET",
    TAG_CARDTYPE_ENUM.BATTLEGROUND_CLICKABLE_BUTTON:       "BATTLEGROUND_CLICKABLE_BUTTON"
}

class TAG_CLASS_ENUM:
    INVALID=0
    DEATHKNIGHT=1
    DRUID=2
    HUNTER=3
    MAGE=4
    PALADIN=5
    PRIEST=6
    ROGUE=7
    SHAMAN=8
    WARLOCK=9
    WARRIOR=10
    DREAM=11
    NEUTRAL=12
    WHIZBANG=13
    DEMONHUNTER=14
TAG_CLASS = {
    TAG_CLASS_ENUM.INVALID:         "无效的",
    TAG_CLASS_ENUM.DEATHKNIGHT:     "巫妖王",
    TAG_CLASS_ENUM.DRUID:           "德鲁伊",
    TAG_CLASS_ENUM.HUNTER:          "猎人",
    TAG_CLASS_ENUM.MAGE:            "法师",
    TAG_CLASS_ENUM.PALADIN:         "圣骑士",
    TAG_CLASS_ENUM.PRIEST:          "潜行者",
    TAG_CLASS_ENUM.ROGUE:           "牧师",
    TAG_CLASS_ENUM.SHAMAN:          "萨满祭司",
    TAG_CLASS_ENUM.WARLOCK:         "术士",
    TAG_CLASS_ENUM.WARRIOR:         "战士",
    TAG_CLASS_ENUM.DREAM:           "梦境",
    TAG_CLASS_ENUM.NEUTRAL:         "中立",
    TAG_CLASS_ENUM.WHIZBANG:        "威兹班",
    TAG_CLASS_ENUM.DEMONHUNTER:     "恶魔猎手"
}

class TAG_CARD_SET_ENUM:
    INVALID=0
    TEST_TEMPORARY=1
    BASIC=2
    EXPERT1=3
    HOF=4
    MISSIONS=5
    DEMO=6
    NONE=7
    CHEAT=8
    BLANK=9
    DEBUG_SP=10
    PROMO=11
    FP1=12
    PE1=13
    BRM=14
    TGT=15
    CREDITS=16
    HERO_SKINS=17
    TB=18
    SLUSH=19
    LOE=20
    OG=21
    OG_RESERVE=22
    KARA=23
    KARA_RESERVE=24
    GANGS=25
    GANGS_RESERVE=26
    UNGORO=27
    ICECROWN = 1001
    TB_DEV = 1003
    LOOTAPALOOZA=1004
    GILNEAS = 1125
    BOOMSDAY = 1127
    TROLL = 1129
    DALARAN=1130
    MY_IGNORE=1143
    ULDUM = 1158
    DRAGONS = 1347
    WILD_EVENT = 1439
    YEAR_OF_THE_DRAGON = 1403
    BATTLEGROUNDS = 1453
    BLACK_TEMPLE = 1414
    DEMON_HUNTER_INITIATE = 1463
    SCHOLOMANCE = 1443
    DARKMOON_FAIRE = 1466
    LETTUCE = 1586
    THE_BARRENS = 1525
    LEGACY = 1635
    CORE = 1637
    VANILLA = 1646
    STORMWIND = 1578
    MERCENARIES_DEV = 1705
    ALTERAC_VALLEY = 1626
    THE_SUNKEN_CITY = 1658
    REVENDRETH = 1691
    RETURN_OF_THE_LICH_KING = 1776
    PATH_OF_ARTHAS = 1869
    BATTLE_OF_THE_BANDS = 1809
    TITANS = 1858
    WONDERS = 1898
    WILD_WEST = 1892
    WHIZBANGS_WORKSHOP = 1897
    TUTORIAL = 1904
    EVENT = 1941
    CORE_HIDDEN = 1810
    ISLAND_VACATION = 1905
    SPACE = 1935
    EMERALD_DREAM = 1946
    THE_LOSt_CITY_OF_UNGORO = 1952

TAG_CARD_SET = {
    TAG_CARD_SET_ENUM.INVALID:                  "0000-失效",
    TAG_CARD_SET_ENUM.TEST_TEMPORARY:           "0001-临时测试",
    TAG_CARD_SET_ENUM.BASIC:                    "0002-基本",
    TAG_CARD_SET_ENUM.EXPERT1:                  "0003-经典",
    TAG_CARD_SET_ENUM.HOF:                      "0004-荣誉室",
    TAG_CARD_SET_ENUM.MISSIONS:                 "0005-新手训练",
    TAG_CARD_SET_ENUM.DEMO:                     "0006-调试",
    TAG_CARD_SET_ENUM.NONE:                     "0007-未知",
    TAG_CARD_SET_ENUM.CHEAT:                    "0008-愚弄",
    TAG_CARD_SET_ENUM.BLANK:                    "0009-空白",
    TAG_CARD_SET_ENUM.DEBUG_SP:                 "0010-测试",
    TAG_CARD_SET_ENUM.PROMO:                    "0011-纪念",
    TAG_CARD_SET_ENUM.FP1:                      "0012-纳克萨玛斯",
    TAG_CARD_SET_ENUM.PE1:                      "0013-地精大战侏儒",
    TAG_CARD_SET_ENUM.BRM:                      "0014-黑石山的火焰",
    TAG_CARD_SET_ENUM.TGT:                      "0015-冠军的试炼",
    TAG_CARD_SET_ENUM.CREDITS:                  "0016-暴雪制作人员",
    TAG_CARD_SET_ENUM.HERO_SKINS:               "0017-英雄皮肤和技能",
    TAG_CARD_SET_ENUM.TB:                       "0018-乱斗模式",
    TAG_CARD_SET_ENUM.SLUSH:                    "0019-混乱",
    TAG_CARD_SET_ENUM.LOE:                      "0020-探险者协会",
    TAG_CARD_SET_ENUM.OG:                       "0021-上古之神的低语",
    TAG_CARD_SET_ENUM.OG_RESERVE:               "0022-上古之神保留",
    TAG_CARD_SET_ENUM.KARA:                     "0023-卡拉赞之夜",
    TAG_CARD_SET_ENUM.KARA_RESERVE:             "0024-卡拉赞保留",
    TAG_CARD_SET_ENUM.GANGS:                    "0025-龙争虎斗加基森",
    TAG_CARD_SET_ENUM.GANGS_RESERVE:            "0026-加基森保留",
    TAG_CARD_SET_ENUM.UNGORO:                   "0027-勇闯安戈洛",
    TAG_CARD_SET_ENUM.ICECROWN:                 "1001-冰封王座的骑士",
    TAG_CARD_SET_ENUM.TB_DEV:                   "1003-天梯实验",
    TAG_CARD_SET_ENUM.LOOTAPALOOZA:             "1004-狗头人与地下世界",
    TAG_CARD_SET_ENUM.GILNEAS:                  "1125-女巫森林",
    TAG_CARD_SET_ENUM.BOOMSDAY:                 "1127-砰砰计划",
    TAG_CARD_SET_ENUM.TROLL:                    "1129-拉斯塔哈的大乱斗",
    TAG_CARD_SET_ENUM.DALARAN:                  "1130-暗影崛起",
    #TAG_CARD_SET_ENUM.MY_IGNORE:                "1143-需要忽略",
    TAG_CARD_SET_ENUM.ULDUM:                    "1158-奥丹姆奇兵",
    TAG_CARD_SET_ENUM.DRAGONS:                  "1347-巨龙降临",
    TAG_CARD_SET_ENUM.WILD_EVENT:               "1439-狂野模式活动",
    TAG_CARD_SET_ENUM.YEAR_OF_THE_DRAGON:       "1403-迦拉克隆的觉醒",
    TAG_CARD_SET_ENUM.BATTLEGROUNDS:            "1453-酒馆战棋",
    TAG_CARD_SET_ENUM.BLACK_TEMPLE:             "1414-外域的灰烬",
    TAG_CARD_SET_ENUM.DEMON_HUNTER_INITIATE:    "1463-恶魔猎手新兵",
    TAG_CARD_SET_ENUM.SCHOLOMANCE:              "1443-通灵学园",
    TAG_CARD_SET_ENUM.DARKMOON_FAIRE:           "1466-疯狂的暗月马戏团",
    TAG_CARD_SET_ENUM.LETTUCE:                  "1586-佣兵战纪",
    TAG_CARD_SET_ENUM.THE_BARRENS:              "1525-贫瘠之地的锤炼",
    TAG_CARD_SET_ENUM.LEGACY:                   "1635-怀旧",
    TAG_CARD_SET_ENUM.CORE:                     "1637-核心",
    TAG_CARD_SET_ENUM.VANILLA:                  "1646-经典",
    TAG_CARD_SET_ENUM.STORMWIND:                "1578-暴风城下的集结",
    TAG_CARD_SET_ENUM.MERCENARIES_DEV:          "1705-佣兵实验",
    TAG_CARD_SET_ENUM.ALTERAC_VALLEY:           "1626-奥特兰克的决裂",
    TAG_CARD_SET_ENUM.THE_SUNKEN_CITY:          "1658-探索沉没之城",
    TAG_CARD_SET_ENUM.REVENDRETH:               "1691-纳斯利亚堡的悬案",
    TAG_CARD_SET_ENUM.RETURN_OF_THE_LICH_KING:  "1776-巫妖王的进军",
    TAG_CARD_SET_ENUM.PATH_OF_ARTHAS:           "1869-阿尔萨斯之路",
    TAG_CARD_SET_ENUM.BATTLE_OF_THE_BANDS:      "1809-传奇音乐节",
    TAG_CARD_SET_ENUM.TITANS:                   "1858-泰坦诸神",
    TAG_CARD_SET_ENUM.WONDERS:                  "1898-时光之穴",
    TAG_CARD_SET_ENUM.WILD_WEST:                "1892-决战荒芜之地",
    TAG_CARD_SET_ENUM.WHIZBANGS_WORKSHOP:       "1897-威兹班的工坊",
    TAG_CARD_SET_ENUM.TUTORIAL:                 "1904-导师",
    TAG_CARD_SET_ENUM.EVENT:                    "1941-活动礼物",
    TAG_CARD_SET_ENUM.CORE_HIDDEN:              "1810-核心(失效)",
    TAG_CARD_SET_ENUM.ISLAND_VACATION:          "1905-胜地历险记",
    TAG_CARD_SET_ENUM.SPACE:                    "1935-深暗领域",
    TAG_CARD_SET_ENUM.EMERALD_DREAM:            "1946-翡翠梦境",
    TAG_CARD_SET_ENUM.THE_LOSt_CITY_OF_UNGORO:  "1952-安戈洛龟途"
}

cardNameEn = ""
cardNameCn = ""
cardTextEn = ""
cardTextCn = ""
cardID = ""
cardEnumID = 0
cardNumberID = 0
cardType = 0
cardClass = 0
cardSet = 0
cardCost = 0
cardAtk = 0
cardHealth = 0
cardDurability = 0

#各文件路径
file_cardIDEnumPath = f"{os.getcwd()}\\CardDB_cardIDEnum.cs"
file_cardNameCNPath = f"{os.getcwd()}\\CardDB_cardNameCN.cs"
file_cardNameENPath = f"{os.getcwd()}\\CardDB_cardNameEN.cs"
file_simOldRootPath = f"{os.getcwd()}\\cards\\"
file_simNewRootPath = f"{os.getcwd()}\\cardsNew\\"
file_cardDefsPath =   f"{os.getcwd()}\\CardDefs.xml"

#获取卡牌ID-中文名键值对
tempCardID=""
tempCardNameCn=""
OldSimIdNameCn = {}
file_cardDefs = open(file_cardDefsPath, 'r', encoding='utf-8')
while 1:
    line = file_cardDefs.readline()
    if not line:
        break

    #读卡牌ID
    if "<Entity CardID=\"" in line:
        index1 = line.find("<Entity CardID=\"")
        index2 = line.find("\"", index1 + 16)
        if index1 == -1 or index2 == -1:
            print(line)
            exit(0)
        tempCardID = line[index1 + 16: index2]

    #读卡牌关键字
    if "<Tag enumID=\"" in line:
        enumIDl = line.find("<Tag enumID=\"")
        enumIDr = line.find("\"", enumIDl + 13)
        if enumIDl == -1 or enumIDr == -1:
            print(line)
            exit(0)
        cardEnumID = int(line[enumIDl + 13: enumIDr])

    #读中文名称和中文描述
    if "<zhCN>" in line:
        if cardEnumID != 185 and cardEnumID != 184:
            continue
        index1 = line.find("<zhCN>")
        index2 = line.find("</zhCN>", index1 + 6)
        text = ""
        while (index2 == -1):
            text += line[index1 + 6:-1]
            line = file_cardDefs.readline()
            index2 = line.find("</zhCN>")
            index1 = -6
        text += line[index1 + 6: index2]
        if index1 == -1 or index2 == -1:
            print("错误：" + line)
            exit(0)
        if cardEnumID == 185:
            tempCardNameCn = html.unescape(text)
            OldSimIdNameCn[tempCardID]=tempCardNameCn
file_cardDefs.close()
#for key, value in OldSimIdNameCn.items():
#    print(key, value)

#读取已经存在的Sim
OldSimContext = []
OldSimCardID = []
OldSimNameCnIdx = {}
OldSimIdIdx = {}
for root, dirs, files in os.walk(file_simOldRootPath):
    for file in files:
        #print(file)
        card_id = file.replace('Sim_', '').replace('.cs', '')
        with open(os.path.join(root, file), "r", encoding='utf-8') as sim_file:
            sim_content = sim_file.read()
            if "public" not in sim_content:
                continue
            card_idx = len(OldSimContext)
            OldSimContext.append(sim_content)
            OldSimCardID.append(card_id)
            OldSimIdIdx[card_id] = card_idx
            if card_id in OldSimIdNameCn:
                OldSimNameCnIdx[OldSimIdNameCn[card_id]] = card_idx
#for key, value in OldSimNameCnIdx.items():
#    print(key, value)

#卡牌枚举文件
file_cardIDEnum = open(file_cardIDEnumPath, 'w', encoding='utf-8')
file_cardNameCN = open(file_cardNameCNPath, 'w', encoding='utf-8')
file_cardNameEN = open(file_cardNameENPath, 'w', encoding='utf-8')
file_cardIDEnum.write("namespace HREngine.Bots\n{\n\tpartial class CardDB\n\t{\n\t\tpublic enum cardIDEnum\n\t\t{\n\t\t\tNone,\n\t\t\thero")
file_cardNameCN.write("namespace HREngine.Bots\n{\n\tpartial class CardDB\n\t{\n\t\tpublic enum cardNameCN\n\t\t{\n\t\t\t未知")
file_cardNameEN.write("namespace HREngine.Bots\n{\n\tpartial class CardDB\n\t{\n\t\tpublic enum cardNameEN\n\t\t{\n\t\t\tunknown,\n\t\t\taiextra1")

#写文件
SimNameCnList = {}
SimNameEnList = {}
if not os.path.exists(file_simNewRootPath):
    os.mkdir(file_simNewRootPath)
file_cardDefs = open(file_cardDefsPath, 'r', encoding='utf-8')
while 1:
    line = file_cardDefs.readline()
    if not line:
        break

    #读卡牌ID
    if "<Entity CardID=\"" in line:
        index1 = line.find("<Entity CardID=\"")
        index2 = line.find("\"", index1 + 16)
        if index1 == -1 or index2 == -1:
            print(line)
            exit(0)
        cardID = line[index1 + 16: index2]
        index1 = line.find("ID=\"", index2)
        index2 = line.find("\"", index1 + 4)
        if index1 == -1 or index2 == -1:
            print(line)
            exit(0)
        cardNumberID = line[index1 + 4: index2]

    #读卡牌关键字
    if "<Tag enumID=\"" in line:
        enumIDl = line.find("<Tag enumID=\"")
        enumIDr = line.find("\"", enumIDl + 13)
        if enumIDl == -1 or enumIDr == -1:
            print(line)
            exit(0)
        cardEnumID = int(line[enumIDl + 13: enumIDr])
        valuel = line.find("value=\"")
        valuer = line.find("\"", valuel + 7)
        if valuel == -1 or valuer == -1:
            continue
        value = int(line[valuel + 7: valuer])
        if cardEnumID == 202:   cardType = value
        elif cardEnumID == 199: cardClass = value
        elif cardEnumID == 183: cardSet = value
        elif cardEnumID == 48:  cardCost = value
        elif cardEnumID == 45:  cardHealth = value
        elif cardEnumID == 47:  cardAtk = value
        elif cardEnumID == 187: cardDurability = value

    #读英文名称和英文描述
    if "<enUS>" in line:
        if cardEnumID != 185 and cardEnumID != 184:
            continue
        index1 = line.find("<enUS>")
        index2 = line.find("</enUS>", index1 + 6)
        text = ""
        while (index2 == -1):
            text += line[index1 + 6:-1]
            line = file_cardDefs.readline()
            index2 = line.find("</enUS>")
            index1 = -6
        text += line[index1 + 6: index2]
        if index1 == -1 or index2 == -1:
            print("错误：" + line)
            exit(0)
        if cardEnumID == 185:
            cardNameEn = html.unescape(text)
        elif cardEnumID == 184:
            cardTextEn = html.unescape(text)

    #读中文名称和中文描述
    if "<zhCN>" in line:
        if cardEnumID != 185 and cardEnumID != 184:
            continue
        index1 = line.find("<zhCN>")
        index2 = line.find("</zhCN>", index1 + 6)
        text = ""
        while (index2 == -1):
            text += line[index1 + 6:-1]
            line = file_cardDefs.readline()
            index2 = line.find("</zhCN>")
            index1 = -6
        text += line[index1 + 6: index2]
        if index1 == -1 or index2 == -1:
            print("错误：" + line)
            exit(0)
        if cardEnumID == 185:
            cardNameCn = html.unescape(text)
        elif cardEnumID == 184:
            cardTextCn = html.unescape(text)

    #读完卡牌,写信息
    if r"</Entity>" in line:
        if cardSet not in TAG_CARD_SET:
            print(f"Ignore cardSet: {cardSet}")
        else:
            if cardType not in TAG_CARDTYPE or \
                cardClass not in TAG_CLASS:
                if cardType not in TAG_CARDTYPE:
                    print(f"No Find cardType: {TAG_CARDTYPE[cardType]}")
                if cardClass not in TAG_CLASS:
                    print(f"No Find cardClass: {TAG_CLASS[cardClass]}")
            else:
                other = " " + TAG_CLASS[cardClass] + " 费用：" + str(cardCost)
                if cardType == TAG_CARDTYPE_ENUM.MINION:#随从
                    other += " 攻击力：" + str(cardAtk) + " 生命值：" + str(cardHealth)
                if cardType == TAG_CARDTYPE_ENUM.WEAPON:#武器
                    other += " 攻击力：" + str(cardAtk) + " 耐久度：" + str(cardDurability)
                #print(cardNameEn,cardNameCn,cardID,TAG_CARDTYPE[cardType])
                #print(TAG_CLASS[cardClass],cardTextEn,cardTextCn)

                #写卡牌枚举
                file_cardIDEnum.write(",\n\t\t\t/// <summary>\n")
                file_cardIDEnum.write("\t\t\t/// <para>"+ TAG_CARDTYPE[cardType] + other +"</para>\n")
                file_cardIDEnum.write("\t\t\t/// <para>"+ cardNameEn +"</para>\n")
                file_cardIDEnum.write("\t\t\t/// <para>"+ cardNameCn +"</para>\n")
                file_cardIDEnum.write("\t\t\t/// <para>"+ cardTextEn +"</para>\n")
                file_cardIDEnum.write("\t\t\t/// <para>"+ cardTextCn +"</para>\n")
                file_cardIDEnum.write("\t\t\t/// </summary>\n")
                file_cardIDEnum.write("\t\t\t" + cardID + " = " + str(cardNumberID))

                #写卡牌中文
                tempCn=re.sub(r'[^a-zA-Z0-9\u4e00-\u9fa5]', '', cardNameCn)
                if len(tempCn)>0 and tempCn[0].isdigit():
                    tempCn=("_"+tempCn)
                    #print(tempCn)
                if tempCn in SimNameCnList:
                    tempCn=tempCn+"_"+cardID
                    #print(tempCn)
                else:
                    SimNameCnList[tempCn]=tempCn
                if tempCn!="":
                    file_cardNameCN.write(",\n\t\t\t/// <summary>\n")
                    file_cardNameCN.write("\t\t\t/// <para>"+ TAG_CARDTYPE[cardType] + other +"</para>\n")
                    file_cardNameCN.write("\t\t\t/// <para>"+ cardNameEn +"</para>\n")
                    file_cardNameCN.write("\t\t\t/// <para>"+ cardNameCn +"</para>\n")
                    file_cardNameCN.write("\t\t\t/// <para>"+ cardTextEn +"</para>\n")
                    file_cardNameCN.write("\t\t\t/// <para>"+ cardTextCn +"</para>\n")
                    file_cardNameCN.write("\t\t\t/// </summary>\n")
                    file_cardNameCN.write("\t\t\t" + tempCn)

                #写卡牌英文
                tempEn=re.sub(r'[^a-zA-Z0-9]', '', cardNameEn.lower())
                if tempEn == "continue" or tempEn == "protected" or \
                    tempEn == "char" or tempEn == "volatile" or \
                    tempEn == "catch":
                    tempEn=("@"+tempEn)
                    #print(tempEn)
                if len(tempEn)>0 and tempEn[0].isdigit():
                    tempEn=("_"+tempEn)
                    #print(tempEn)
                if tempEn in SimNameEnList:
                    tempEn=tempEn+"_"+cardID
                    #print(tempEn)
                else:
                    SimNameEnList[tempEn]=tempEn
                if tempEn!="":
                    file_cardNameEN.write(",\n\t\t\t/// <summary>\n")
                    file_cardNameEN.write("\t\t\t/// <para>"+ TAG_CARDTYPE[cardType] + other +"</para>\n")
                    file_cardNameEN.write("\t\t\t/// <para>"+ cardNameEn +"</para>\n")
                    file_cardNameEN.write("\t\t\t/// <para>"+ cardNameCn +"</para>\n")
                    file_cardNameEN.write("\t\t\t/// <para>"+ cardTextEn +"</para>\n")
                    file_cardNameEN.write("\t\t\t/// <para>"+ cardTextCn +"</para>\n")
                    file_cardNameEN.write("\t\t\t/// </summary>\n")
                    file_cardNameEN.write("\t\t\t" + tempEn)

                #写卡牌Sim
                if cardType==TAG_CARDTYPE_ENUM.ENCHANTMENT:#附魔
                    print(f"Ignore cardType: {TAG_CARDTYPE[cardType]}[{cardID}:{cardNameCn}]")
                else:
                    sim_data=""
                    directory = f"{file_simNewRootPath}"+TAG_CARD_SET[cardSet]
                    if not os.path.exists(directory):
                        os.mkdir(directory)
                    if cardID in OldSimIdIdx:
                        sim_data = OldSimContext[OldSimIdIdx[cardID]]
                    if cardNameCn in OldSimNameCnIdx:
                        idx = OldSimNameCnIdx[cardNameCn]
                        if idx in OldSimIdIdx:
                            sim_id = OldSimIdIdx[idx]
                            sim_data = OldSimContext[idx]
                            sim_data = sim_data.replace(f'class Sim_{sim_id}', f'class Sim_{cardID}')
                    with open(directory + "\\Sim_" + cardID + ".cs", 'w', encoding='utf-8') as sim:
                        if sim_data!="":
                            sim.write(sim_data)
                        else:
                            sim.write("using System;\nusing System.Collections.Generic;\nusing System.Text;\n\n");
                            sim.write("namespace HREngine.Bots\n{\n");
                            sim.write("\t//" + TAG_CARDTYPE[cardType] + other + "\n")
                            sim.write("\t//" + cardNameEn + "\n")
                            sim.write("\t//" + cardNameCn + "\n")
                            sim.write("\t//" + cardTextEn + "\n")
                            sim.write("\t//" + cardTextCn + "\n")
                            sim.write("\tclass Sim_" + cardID +" : SimTemplate" + "\n\t{\n")
                            sim.write("\t\t\n\t\t\n\t}\n}\n")

        #读取一张卡牌结束
        cardNameEn = ""
        cardNameCn = ""
        cardTextEn = ""
        cardTextCn = ""
        cardID = ""
        cardEnumID = 0
        cardNumberID = 0
        cardType = 0
        cardClass = 0
        cardSet = 0
        cardCost = 0
        cardAtk = 0
        cardHealth = 0
        cardDurability = 0

#写文件结尾
file_cardIDEnum.write("\n\t\t}\n\t}\n}\n")
file_cardNameCN.write("\n\t\t}\n\t}\n}\n")
file_cardNameEN.write("\n\t\t}\n\t}\n}\n")
file_cardIDEnum.close()
file_cardNameCN.close()
file_cardNameEN.close()
file_cardDefs.close()
