using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_CFM_687 : SimTemplate //* 墨水大师索莉娅 Inkmaster Solia
//[x]<b>Battlecry:</b> If your deck hasno duplicates, the nextspell you cast this turncosts (0).
//<b>战吼：</b>在本回合中，如果你的牌库里没有相同的牌，你所施放的下一个法术的法力值消耗为（0）点。 
	{
		

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own && p.prozis.noDuplicates) p.nextSpellThisTurnCost0 = true;
        }
    }
}