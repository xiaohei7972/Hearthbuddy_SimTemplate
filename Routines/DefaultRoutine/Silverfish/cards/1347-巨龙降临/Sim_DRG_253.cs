namespace HREngine.Bots
{
    class Sim_DRG_253 : SimTemplate //* 矮人神射手 Dwarven Sharpshooter
    {
        //Your Hero Power can target minions.
        //你的英雄技能能够以随从为目标。
        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own) p.weHaveSteamwheedleSniper = true;
            else p.enemyHaveSteamwheedleSniper = true;
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                bool hasss = false;
                foreach (Minion mnn in p.ownMinions)
                {
                    if (m.name == CardDB.cardNameEN.steamwheedlesniper && !mnn.silenced) hasss = true;
                }
                p.weHaveSteamwheedleSniper = hasss;
            }
            else
            {
                bool hasss = false;
                foreach (Minion mnn in p.enemyMinions)
                {
                    if (m.name == CardDB.cardNameEN.steamwheedlesniper && !mnn.silenced) hasss = true;
                }
                p.enemyHaveSteamwheedleSniper = hasss;
            }
        }

    }
}