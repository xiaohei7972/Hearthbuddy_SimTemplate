using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_335 : SimTemplate //* 驯羊师 ramtamer
	{
		//<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1和<b>潜行</b>。
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            if (p.ownSecretsIDList.Count >= 1)
            {
                p.minionGetBuffed(own, 1, 1);
                own.stealth = true;
            }
        }
		
	}
}
