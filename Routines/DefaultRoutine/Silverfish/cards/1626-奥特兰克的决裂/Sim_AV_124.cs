using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_124 : SimTemplate //* 恐狼指挥官 direwolfcommander
	{
		//<b>荣誉消灭：</b> 召唤一只2/2并具有<b>潜行</b>的狼。
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AV_211t);

        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp && !target.divineshild)
            {
                p.callKid(kid, attacker.zonepos, attacker.own);
            }
        }
		
	}
}
