using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 潜行者 费用：0
	//Bandage
	//绷带
	//Restore #3 Health.
	//恢复#3点生命值。
	class Sim_TOY_382t : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.minionGetDamageOrHeal(target, -3); // 恢复3点生命值
        }
    }
}
