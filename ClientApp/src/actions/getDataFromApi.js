import { get } from "../services/requestHelpers";

export const getGroupProducts = async () => {
  try {
    const response = await get("products");
    return response.data;
  } catch (err) {
    console.log(err);
    return null;
  }
};

export const getProduct = async (id) => {
  try {
    const response = await get("product?id=" + id);
    return response.data;
  } catch (err) {
    console.log(err);
    return null;
  }
};
