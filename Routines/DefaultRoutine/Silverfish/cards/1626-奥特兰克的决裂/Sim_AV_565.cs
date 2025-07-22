using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AV_565 : SimTemplate //* 执斧狂战士 axeberserker
	{
		//<b>突袭</b>，<b>荣誉消灭：</b>抽一张武器牌。
        public override void OnHonorableKill(Playfield p, Minion attacker, Minion target)
        {
            if (target != null && attacker.Angr == target.Hp)
            {
                p.drawACard(CardDB.cardIDEnum.None, attacker.own, false);
            }
        }
		
	}
}
