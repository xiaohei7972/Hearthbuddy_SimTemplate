using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Slippery Slope
	//滑坡
	//<b>Freeze</b> a character. Draw a card for each <b>Frozen</b> character.
	//<b>冻结</b>一个角色。每有一个被<b>冻结</b>的角色，抽一张牌。
	class Sim_VAC_513 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                p.minionGetFrozen(target); // 冻结目标角色

                int frozenCount = 0;

                // 计算所有被冻结的角色数量
                if (p.ownHero.frozen) frozenCount++;
                if (p.enemyHero.frozen) frozenCount++;
                foreach (Minion m in p.ownMinions)
                {
                    if (m.frozen) frozenCount++;
                }
                foreach (Minion m in p.enemyMinions)
                {
                    if (m.frozen) frozenCount++;
                }

                // 每有一个被冻结的角色，抽一张牌
                for (int i = 0; i < frozenCount; i++)
                {
                    p.drawACard(CardDB.cardIDEnum.None, ownplay);
                }
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_IF_AVAILABLE)  // 目标必须是角色
            };
        }
    }
}
