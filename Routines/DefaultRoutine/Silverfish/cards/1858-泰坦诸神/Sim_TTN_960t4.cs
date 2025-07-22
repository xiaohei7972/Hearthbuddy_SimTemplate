using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 术士 费用：0
	//Legion Invasion!
	//军团进攻！
	//Future Demons summoned from the Twisting Nether have+2 Health and <b>Taunt</b>.
	//此后从扭曲虚空召唤的恶魔拥有+2生命值和<b>嘲讽</b>。
	class Sim_TTN_960t4 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (ownplay) p.ownLegionInvasion = true;
			else p.enemyLegionInvasion = true;
        }
    }
}
