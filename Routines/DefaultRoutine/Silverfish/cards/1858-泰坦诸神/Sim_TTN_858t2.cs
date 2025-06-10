using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：0
	//Empowered
	//强化
	//Give your otherminions +2/+2.
	//使你的所有其他随从获得+2/+2。
	class Sim_TTN_858t2 : SimTemplate
	{
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            p.ownMinions.ForEach(m =>
            {
                m.Angr += 2;
                m.Hp += 2;
            });
        }
    }
}
