import { get } from "../services/requestHelpers";

export const getWeatherInfo = async () => {
  try {
    const response = await get("weatherforecast");
    return response.data;
  } catch (err) {
    console.log(err);
    return null;
  }
};
