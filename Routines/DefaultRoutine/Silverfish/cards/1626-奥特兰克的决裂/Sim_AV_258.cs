using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_258 : SimTemplate //* 元素使者布鲁坎 brukanoftheelements
	{
		//<b>战吼：</b>唤起两种元素之力！
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.setNewHeroPower(CardDB.cardIDEnum.AV_258p, ownplay);
            if (ownplay) p.ownHero.armor += 5;
            else p.enemyHero.armor += 5;
        }
		
	}
}
