using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//地标 术士 费用：2
	//Vile Library
	//邪恶图书馆
	//[x]{0}{1}
	//{0}{1}
	class Sim_REV_799 : SimTemplate
	{
		public override void useLocation(Playfield p, Minion triggerMinion, Minion target)
        {
            // 检查目标是否为有效随从
            if (target != null)
            {
                // 基础增加 +1/+1
                int buffAmount = 1;

                // 计算场上己方小鬼的数量
                int impCount = 0;
                foreach (Minion m in p.ownMinions)
                {
                    if (m.name == CardDB.cardNameEN.imp ||
                        m.name == CardDB.cardNameEN.bloodimp ||
                        m.name == CardDB.cardNameEN.worthlessimp ||
                        m.name == CardDB.cardNameEN.flameimp ||
                        m.name == CardDB.cardNameEN.impgangboss ||
                        m.name == CardDB.cardNameEN.malchezaarsimp ||
                        m.name == CardDB.cardNameEN.ickyimp ||
                        m.name == CardDB.cardNameEN.netherimp ||
                        m.name == CardDB.cardNameEN.doublingimp ||
                        m.name == CardDB.cardNameEN.jumboimp ||
                        m.name == CardDB.cardNameEN.deviousimp ||
                        m.name == CardDB.cardNameEN.draconicimp ||
                        m.name == CardDB.cardNameEN.impcaster ||
                        m.name == CardDB.cardNameEN.imprisonedscrapimp ||
                        m.name == CardDB.cardNameEN.deskimp ||
                        m.name == CardDB.cardNameEN.fieryimp ||
                        m.name == CardDB.cardNameEN.impfamiliar ||
                        m.name == CardDB.cardNameEN.sulkingimp ||
                        m.name == CardDB.cardNameEN.bloodboundimp ||
                        m.name == CardDB.cardNameEN.backpiggyimp ||
                        m.name == CardDB.cardNameEN.dreadimp ||
                        m.name == CardDB.cardNameEN.piggybackimp ||
                        m.name == CardDB.cardNameEN.mischievousimp ||
                        m.name == CardDB.cardNameEN.baritoneimp ||
                        m.name == CardDB.cardNameEN.orchestralimp ||
                        m.name == CardDB.cardNameEN.fiddlefireimp ||
                        m.name == CardDB.cardNameEN.felblazeimp ||
                        m.name == CardDB.cardNameEN.sacrificialimp ||
                        m.name == CardDB.cardNameEN.monstrousimp
                        ) // 检查小鬼的卡牌名称
                    {
                        impCount++;
                    }
                }

                // 为目标随从增加 (1 + impCount) 点攻击力和生命值
                p.minionGetBuffed(target, buffAmount + impCount, buffAmount + impCount);
            }
        }

        public override PlayReq[] GetUseAbilityReqs()
        {
            return new PlayReq[]
            {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标才能使用
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET), // 目标必须是友方随从
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 目标必须是一个随从
            };
        }
	}
}
