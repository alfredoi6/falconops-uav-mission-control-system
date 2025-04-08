import axios from 'axios';

// Create an axios instance
const apiClient = axios.create({
  // Read the base URL from environment variables
  // Vite exposes env variables prefixed with VITE_ on import.meta.env
  // Make sure to create a .env file in the FalconOps.Web root
  // and add VITE_API_BASE_URL=http://localhost:YOUR_API_PORT/api
  baseURL: import.meta.env.VITE_API_BASE_URL || 'http://localhost:5000/api', // Fallback URL
  headers: {
    'Content-Type': 'application/json',
  },
});

// Optional: Add interceptors for request/response handling (e.g., adding auth tokens)
apiClient.interceptors.request.use(
  (config) => {
    // Example: Get token from local storage or state management
    const token = localStorage.getItem('authToken'); // Adjust storage method as needed
    if (token) {
      config.headers.Authorization = `Bearer ${token}`;
    }
    return config;
  },
  (error) => {
    return Promise.reject(error);
  }
);

// Optional: Add interceptors for error handling (e.g., redirect on 401)
apiClient.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.response && error.response.status === 401) {
      // Example: Handle unauthorized access - redirect to login, clear token, etc.
      console.error('Unauthorized access - redirecting to login');
      // window.location.href = '/login'; // Uncomment and adjust as needed
    }
    return Promise.reject(error);
  }
);

export default apiClient;
