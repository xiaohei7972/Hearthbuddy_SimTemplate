using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_759 : SimTemplate //* 海象人执法官 Meanstreet Marshal
//<b>Deathrattle:</b> If this minion has 2 or more Attack, draw a card.
//<b>亡语：</b>如果该随从的攻击力大于或等于2，抽一张牌。 
	{
		

        public override void onDeathrattle(Playfield p, Minion m)
        {
            if (m.Angr >= 2) p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
    }
}