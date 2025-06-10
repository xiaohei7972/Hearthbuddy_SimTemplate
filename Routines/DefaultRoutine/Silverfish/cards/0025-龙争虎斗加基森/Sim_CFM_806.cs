using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_806 : SimTemplate //* 拉希奥 Wrathion
//<b>Taunt</b>. <b>Battlecry:</b> Draw cards until you draw one that isn't a Dragon.
//<b>嘲讽，战吼：</b>抽若干数量的牌，直到你抽到一张非龙牌。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, m.own);
            p.drawACard(CardDB.cardIDEnum.None, m.own);
        }
    }
}