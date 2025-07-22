using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 法师 费用：6 攻击力：5 生命值：5
	//Puzzlemaster Khadgar
	//益智大师卡德加
	//[x]<b>Battlecry:</b> Equip a 0/6Wisdomball that castshelpful Mage spells!
	//<b>战吼：</b>装备一个会施放有用的法师法术的0/6的魔法智慧之球！
	class Sim_TOY_373 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 装备一个 0/6 的魔法智慧之球
            p.equipWeapon(CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TOY_373t), own.own);
        }
    }
}
