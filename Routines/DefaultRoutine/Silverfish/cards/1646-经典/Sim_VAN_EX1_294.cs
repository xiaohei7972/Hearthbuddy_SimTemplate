using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_294 : SimTemplate //* 镜像实体 Mirror Entity
	{
		//<b>Secret:</b> After your opponent plays a minion, summon a copy of it.
		//<b>奥秘：</b>在你的对手使用一张随从牌后，召唤一个该随从的复制。

        public override void onSecretPlay(Playfield p, bool ownplay, Minion target, int number)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(target.handcard.card, pos, ownplay);
            if (ownplay)
            {
                if (p.ownMinions.Count >= 1 && p.ownMinions[p.ownMinions.Count - 1].name == target.handcard.card.nameEN)
                {
                    int e = p.ownMinions[p.ownMinions.Count - 1].entitiyID;
                    p.ownMinions[p.ownMinions.Count - 1].setMinionToMinion(target);
                    p.ownMinions[p.ownMinions.Count - 1].entitiyID = e;
                    p.ownMinions[p.ownMinions.Count - 1].own = true;
                }
            }
            else
            {
                if (p.enemyMinions.Count >= 1 && p.enemyMinions[p.enemyMinions.Count - 1].name == target.handcard.card.nameEN)
                {
                    int e = p.enemyMinions[p.enemyMinions.Count - 1].entitiyID;
                    p.enemyMinions[p.enemyMinions.Count - 1].setMinionToMinion(target);
                    p.enemyMinions[p.enemyMinions.Count - 1].entitiyID = e;
                    p.enemyMinions[p.enemyMinions.Count - 1].own = false;
                }
            }
        }
    }
}