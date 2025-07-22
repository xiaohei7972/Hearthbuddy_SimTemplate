using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 中立 费用：4 攻击力：3 生命值：5
	//Resort Valet
	//景区代泊
	//<b>Battlecry:</b> <b>Discover</b> acard from the newest expansion.
	//<b>战吼：</b><b>发现</b>一张最新扩展包的牌。
	class Sim_VAC_432 : SimTemplate
	{
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            // 模拟从最新扩展包中 "发现" 一张牌，这里简单实现为随机抽一张牌
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}
