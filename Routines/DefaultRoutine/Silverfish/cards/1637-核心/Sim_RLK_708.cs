using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：3 攻击力：2 生命值：2
	//Chillfallen Baron
	//堕寒男爵
	//<b>Battlecry and Deathrattle:</b> Draw a card.
	//<b>战吼，亡语：</b>抽一张牌。
	class Sim_RLK_708 : SimTemplate
	{
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.drawACard(CardDB.cardIDEnum.None, own.own);
		}
		
		public override void onDeathrattle(Playfield p, Minion m)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
	}
}
