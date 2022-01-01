using protonApp.Data;
using System;

namespace protonApp.Model
{
    internal class PointsCalculator
    {
        internal int calculatePoints(
            string type,
            bool isRelay = false,
            int relayCount = 0,
            int peopleCount = 0,
            bool isChessOrSwimming = false,
            int playerCount = 0,
            int playerPlace = 0,
            int gradeForOrganization = 0,
            bool higherRankEvent = false,
            int teamCount = 0,
            bool isPingpongOrBadmintonOrRingoOrStreetballOrBridge = false,
            int matchCount = 0,
            string championsType = ""
        )
        {
            int[,] bonus = SportBonusData.bonusByPlace;
            int points = 0;

            switch (type)
            {
                case "Dyscypliny indywidualne":
                    if (isRelay)
                    {
                        points = relayCount * peopleCount;
                    }
                    else
                    {
                        if (playerCount <= 10)
                        {
                            points = 6;
                        }
                        else if (playerCount > 10 && playerCount <= 15)
                        {
                            points = 7;
                        }
                        else
                        {
                            points = 7;
                            if (playerPlace >= 10)
                                points -= 1;
                        }
                        if (isChessOrSwimming)
                            points -= 1;

                    }
                    switch (playerPlace)
                    {
                        case 1:
                            points += 10;
                            break;
                        case 2:
                            points += 8;
                            break;
                        case 3:
                            points += 7;
                            break;
                        case 4:
                            points += 6;
                            break;
                        case 5:
                            points += 5;
                            break;
                        case 6:
                            points += 4;
                            break;
                        case 7:
                            points += 3;
                            break;
                        case 8:
                            points += 2;
                            break;
                        case 9:
                            points += 1;
                            break;
                    }
                    break;

                case "Trening":
                    points = 8;
                    break;

                case "Organizacja":
                    points = gradeForOrganization;
                    if (higherRankEvent)
                        points *= 2;
                    break;

                case "Sędziowanie":
                    //TODO
                    break;

                case "Dyscypliny zespołowe":
                    if (isPingpongOrBadmintonOrRingoOrStreetballOrBridge)
                        points = teamCount + matchCount * 3;
                    else
                        points = teamCount * 3 + matchCount * 3;
                    points -= (playerPlace - 1) * 3;
                    break;

                case "Dyscypliny indywidualne drużynowe":
                    try
                    {
                        switch (championsType)
                        {
                            case "Mistrzostwa województwa":
                                points = bonus[playerPlace - 1, 1] + 5;
                                break;
                            case "Mistrzostwa Wrocławia":
                                points = bonus[playerPlace - 1, 1];
                                break;
                            case "Mistrzostwa dzielnicy":
                                points = bonus[playerPlace - 1, 3] + 5;
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "FATAL ERROR", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    }

                    if (playerPlace <= 5)
                        points += (6 - playerPlace);
                    break;
            }
            return points;
        }
    }
}
