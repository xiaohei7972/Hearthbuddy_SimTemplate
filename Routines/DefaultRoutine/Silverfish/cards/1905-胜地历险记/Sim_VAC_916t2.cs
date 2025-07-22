using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Divine Brew
	//神圣佳酿
	//Give a character <b>Divine Shield</b>. If it already had one, give it +1 Attack this turn. <i>(2 Drinks left!)</i>
	//使一个角色获得<b>圣盾</b>。如果其已经拥有圣盾，使其在本回合中获得+1攻击力。<i>（还剩2杯！）</i>
	class Sim_VAC_916t2 : SimTemplate
	{

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null)
            {
                if (target.divineshild)
                {
                    // 如果目标已有圣盾，增加1点攻击力（仅限本回合）
                    p.minionGetTempBuff(target, 1, 0);
                }
                else
                {
                    // 否则给予目标圣盾
                    target.divineshild = true;
                }

                // 触发“还剩3杯”的效果，抽一张指定卡牌（假设卡牌ID为 VAC_916t3）
                p.drawACard(CardDB.cardIDEnum.VAC_916t3, ownplay, true);
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
