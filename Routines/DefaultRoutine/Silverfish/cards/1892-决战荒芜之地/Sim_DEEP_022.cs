using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 牧师 费用：1
	//Fool's Gold
	//愚人金
	//Get a random Golden Pirate and Elemental from other classes.
	//随机获取其他职业的金色海盗牌和元素牌各一张。
	class Sim_DEEP_022 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
            p.drawACard(CardDB.cardIDEnum.None, ownplay);
        }

    }
}
