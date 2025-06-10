using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：2
	//Petty Theft
	//小偷小摸
	//Get two random1-Cost spells from other classes.
	//随机获取两张其他职业的法力值消耗为（1）的法术牌。
	class Sim_VAC_335 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 2; i++)
            {
                // 随机获取一张卡牌
                p.drawACard(CardDB.cardIDEnum.None, ownplay, true);
            }
        }
    }
}
